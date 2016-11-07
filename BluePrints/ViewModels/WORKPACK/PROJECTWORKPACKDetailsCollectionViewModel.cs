﻿using BluePrints.BluePrintsEntitiesDataModel;
using BluePrints.Common.DataModel;
using BluePrints.Common.ViewModel;
using BluePrints.Common.ViewModel.Utils;
using BluePrints.Data;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrints.ViewModels
{
    public class PROJECTWORKPACKDetailsCollectionViewModel : DetailsFilterableSingleObjectViewModel<PROJECT, WORKPACK, Guid, IBluePrintsEntitiesUnitOfWork>
    {
        /// <summary>
        /// Initializes a new instance of the PROJECTViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PROJECTViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PROJECTWORKPACKDetailsCollectionViewModel(IUnitOfWorkFactory<IBluePrintsEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? BluePrintsEntitiesUnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PROJECTS, x => x.NUMBER)
        {
        }

        /// <summary>
        /// Allow cells to commit immediately upon losing focus
        /// </summary>
        public void CellValueChanged(CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "GUID_DDISCIPLINE" || e.Column.FieldName == "GUID_DDOCTYPE")
            {
                WORKPACK changedWORKPACK = (WORKPACK)e.Row;
                changedWORKPACK.INTERNAL_NAME1 = BluePrintDataUtils.WORKPACK_Generate_InternalNumber1(Entity, changedWORKPACK, PROJECTWORKPACKSDetails.Entities, LookUpAREAS, LookUpDISCIPLINES, LookUpDOCTYPES);

                if (e.Column.FieldName == "GUID_DDISCIPLINE")
                {
                    changedWORKPACK.INTERNAL_NAME2 = BluePrintDataUtils.WORKPACK_Generate_InternalNumber2(Entity, changedWORKPACK, PROJECTWORKPACKSDetails.Entities, LookUpAREAS, LookUpDISCIPLINES, LookUpPHASES);
                }
            }
            else if (e.Column.FieldName == "GUID_DPHASE" || e.Column.FieldName == "GUID_DAREA")
            {
                WORKPACK changedWORKPACK = (WORKPACK)e.Row;
                changedWORKPACK.INTERNAL_NAME2 = BluePrintDataUtils.WORKPACK_Generate_InternalNumber2(Entity, changedWORKPACK, PROJECTWORKPACKSDetails.Entities, LookUpAREAS, LookUpDISCIPLINES, LookUpPHASES);
            }
            else if (e.Column.FieldName == "STARTDATE" || e.Column.FieldName == "ENDDATE" || e.Column.FieldName == "REVIEWSTARTDATE" || e.Column.FieldName == "REVIEWENDDATE")
            {
                WORKPACK changedWORKPACK = (WORKPACK)e.Row;
                changedWORKPACK.AUTOGENERATED = false;
            }
        }

        public void CellValueChanging(CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "GUID_DDOCTYPE")
            {
                WORKPACK changingWORKPACK = (WORKPACK)e.Row;
                DOCTYPE chosenDOCTYPE = LookUpDOCTYPES.Entities.FirstOrDefault(entity => entity.GUID == (Guid)e.Value);
                if (chosenDOCTYPE != null && chosenDOCTYPE.GUID_DDEPARTMENT != null)
                {
                    changingWORKPACK.GUID_DDEPARTMENT = chosenDOCTYPE.DEPARTMENT.GUID;
                    PROJECTWORKPACKSDetails.UpdateSelectedEntity();
                }
            }
            else if (e.Column.FieldName == "STARTDATE" || e.Column.FieldName == "ENDDATE")
            {
                DateTime startDate;
                DateTime endDate;

                WORKPACK changingWORKPACK = (WORKPACK)e.Row;
                if (e.Column.FieldName == "STARTDATE")
                {
                    startDate = (DateTime)e.Value;
                    endDate = changingWORKPACK.ENDDATE;
                    if (endDate < startDate)
                    {
                        endDate = BluePrintDataUtils.WORKPACK_Calculate_EndDate(startDate, Entity);
                        changingWORKPACK.ENDDATE = endDate;
                    }
                }
                else
                {
                    endDate = (DateTime)e.Value;
                    startDate = changingWORKPACK.STARTDATE;
                    if (endDate < startDate)
                    {
                        startDate = BluePrintDataUtils.WORKPACK_Calculate_StartDate(endDate, Entity);
                        changingWORKPACK.STARTDATE = startDate;
                    }
                }

                DateTime reviewStartDate = startDate;
                DateTime reviewEndDate = endDate;

                BluePrintDataUtils.WORKPACK_Calculate_ReviewPeriod(ref reviewStartDate, ref reviewEndDate, Entity, false);
                changingWORKPACK.REVIEWSTARTDATE = reviewStartDate;

                if (reviewEndDate >= endDate)
                    changingWORKPACK.REVIEWENDDATE = endDate;
                else
                    changingWORKPACK.REVIEWENDDATE = reviewEndDate;

                PROJECTWORKPACKSDetails.UpdateSelectedEntity();
            }
        }

        /// <summary>
        /// The view model for the PROJECTWORKPACKS detail collection.
        /// </summary>
        public CollectionViewModel<WORKPACK, Guid, IBluePrintsEntitiesUnitOfWork> PROJECTWORKPACKSDetails
        {
            get { return GetDetailsCollectionViewModel((PROJECTViewModel x) => x.PROJECTWORKPACKSDetails, x => x.WORKPACKS, x => x.GUID_PROJECT, (x, key) => { x.GUID_PROJECT = key; }); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of PHASES for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PHASE> LookUpPHASES
        {
            get { return GetLookUpEntitiesViewModel((PROJECTViewModel x) => x.LookUpPHASES, x => x.PHASES, query => query.Where(phase => phase.GUID_PROJECT == Entity.GUID)); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of AREAS for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<AREA> LookUpAREAS
        {
            get { return GetLookUpEntitiesViewModel((PROJECTViewModel x) => x.LookUpAREAS, x => x.AREAS, query => query.Where(area => area.GUID_PROJECT == Entity.GUID)); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of DEPARTMENTS for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DEPARTMENT> LookUpDEPARTMENTS
        {
            get { return GetLookUpEntitiesViewModel((PROJECTViewModel x) => x.LookUpDEPARTMENTS, x => x.DEPARTMENTS); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of DISCIPLINES for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DISCIPLINE> LookUpDISCIPLINES
        {
            get { return GetLookUpEntitiesViewModel((PROJECTViewModel x) => x.LookUpDISCIPLINES, x => x.DISCIPLINES); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of DOCTYPES for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DOCTYPE> LookUpDOCTYPES
        {
            get { return GetLookUpEntitiesViewModel((PROJECTViewModel x) => x.LookUpDOCTYPES, x => x.DOCTYPES); }
        }
    }

}