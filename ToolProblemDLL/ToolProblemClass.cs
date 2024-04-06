/* Title:           Tool Problem Class
 * Date:            7-17-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the class for the tool problems */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ToolProblemDLL
{
    public class ToolProblemClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        ToolProblemDataSet aToolProblemDataSet;
        ToolProblemDataSetTableAdapters.toolproblemTableAdapter aToolProblemTableAdapter;

        ToolProblemUpdateDataSet aToolProblemUpdateDataSet;
        ToolProblemUpdateDataSetTableAdapters.toolproblemupdateTableAdapter aToolProblemUpdateTableAdapter;

        InsertToolProblemEntryTableAdapters.QueriesTableAdapter aInsertToolProblemTableAdapter;

        InsertToolProblemUpdateEntryTableAdapters.QueriesTableAdapter aInsertToolProblemUpdateTableAdapter;

        UpdateToolProblemRepairStatusEntryTableAdapters.QueriesTableAdapter aUpdateToolProblemRepairStatusTableAdapter;

        FindToolProblemByToolKeyDataSet aFindToolProblemByToolKeyDataSet;
        FindToolProblemByToolKeyDataSetTableAdapters.FindToolProblemByToolKeyTableAdapter aFindToolProblemByToolKeyTableAdapter;

        FindToolProblemUpdateByProblemIDDataSet aFindToolProblemUpdateByProblemIDDataSet;
        FindToolProblemUpdateByProblemIDDataSetTableAdapters.FindToolProblemUpdateByProblemIDTableAdapter aFindToolProblemUpdateByProblemIDTableAdapter;

        FindToolProblemByDateRangeDataSet aFindToolProblemByDateRangeDataSet;
        FindToolProblemByDateRangeDataSetTableAdapters.FindToolProblemByDateRangeTableAdapter aFindToolProblemByDateRangeTableAdapter;

        ToolProblemDocumentsDataSet aToolProblemDocumentsDataSet;
        ToolProblemDocumentsDataSetTableAdapters.toolproblemdocumentsTableAdapter aToolProblemDocumentsTableAdapter;

        InsertToolProblemDocumentEntryTableAdapters.QueriesTableAdapter aInsertToolProblemDocumentTableAdapter;

        FindToolProblemDocumentByProblemIDDataSet aFindToolProblemDocumentByProblemIDDataSet;
        FindToolProblemDocumentByProblemIDDataSetTableAdapters.FindToolProblemDocumentByProblemIDTableAdapter aFindToolProblemDocumentByProblemIDTableAdapter;

        FindToolProblemByEmployeeIDDataSet aFindToolProblemByEmployeeIDDataSet;
        FindToolProblemByEmployeeIDDataSetTableAdapters.FindToolProblemByEmployeeIDTableAdapter aFindToolProblemByEmployeeIDTableAdapter;

        FindToolProblemByDateMatchDataSet aFindToolProblemByDateMatchDataSet;
        FindToolProblemByDateMatchDataSetTableAdapters.FindToolProblemByDateMatchTableAdapter aFindToolProblemByDateMatchTableAdapter;

        FindOpenToolProblemsDataSet aFindOpenToolProblemsDataSet;
        FindOpenToolProblemsDataSetTableAdapters.FindOpenToolProblemsTableAdapter aFindOpenToolProblemsTableAdapter;

        public FindOpenToolProblemsDataSet FindOpenToolProblems()
        {
            try
            {
                aFindOpenToolProblemsDataSet = new FindOpenToolProblemsDataSet();
                aFindOpenToolProblemsTableAdapter = new FindOpenToolProblemsDataSetTableAdapters.FindOpenToolProblemsTableAdapter();
                aFindOpenToolProblemsTableAdapter.Fill(aFindOpenToolProblemsDataSet.FindOpenToolProblems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Find Open Tool Problems " + Ex.Message);
            }

            return aFindOpenToolProblemsDataSet;
        }
        public FindToolProblemByDateMatchDataSet FindToolProblemByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindToolProblemByDateMatchDataSet = new FindToolProblemByDateMatchDataSet();
                aFindToolProblemByDateMatchTableAdapter = new FindToolProblemByDateMatchDataSetTableAdapters.FindToolProblemByDateMatchTableAdapter();
                aFindToolProblemByDateMatchTableAdapter.Fill(aFindToolProblemByDateMatchDataSet.FindToolProblemByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Find Tool Problem By Date Match " + Ex.Message);

            }

            return aFindToolProblemByDateMatchDataSet;
        }
        public FindToolProblemByEmployeeIDDataSet FindToolProblemByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindToolProblemByEmployeeIDDataSet = new FindToolProblemByEmployeeIDDataSet();
                aFindToolProblemByEmployeeIDTableAdapter = new FindToolProblemByEmployeeIDDataSetTableAdapters.FindToolProblemByEmployeeIDTableAdapter();
                aFindToolProblemByEmployeeIDTableAdapter.Fill(aFindToolProblemByEmployeeIDDataSet.FindToolProblemByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Find Tool Problem by Employee ID " + Ex.Message);
            }

            return aFindToolProblemByEmployeeIDDataSet;
        }
        public FindToolProblemDocumentByProblemIDDataSet FindToolProblemDocumentByProblemID(int intProblemID)
        {
            try
            {
                aFindToolProblemDocumentByProblemIDDataSet = new FindToolProblemDocumentByProblemIDDataSet();
                aFindToolProblemDocumentByProblemIDTableAdapter = new FindToolProblemDocumentByProblemIDDataSetTableAdapters.FindToolProblemDocumentByProblemIDTableAdapter();
                aFindToolProblemDocumentByProblemIDTableAdapter.Fill(aFindToolProblemDocumentByProblemIDDataSet.FindToolProblemDocumentByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Find Tool Problem Document By Problem ID " + Ex.Message);
            }

            return aFindToolProblemDocumentByProblemIDDataSet;
        }
        public bool InsertToolProblemDocument(int intProblemID, string strDocumentType, string strDocumentPath)
        {
            bool blnFatalError = false;

            try
            {
                aInsertToolProblemDocumentTableAdapter = new InsertToolProblemDocumentEntryTableAdapters.QueriesTableAdapter();
                aInsertToolProblemDocumentTableAdapter.InsertToolProblemDocument(DateTime.Now, intProblemID, strDocumentType, strDocumentPath);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Insert Tool Problem Document " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ToolProblemDocumentsDataSet GetToolProblemDocumentsInfo()
        {
            try
            {
                aToolProblemDocumentsDataSet = new ToolProblemDocumentsDataSet();
                aToolProblemDocumentsTableAdapter = new ToolProblemDocumentsDataSetTableAdapters.toolproblemdocumentsTableAdapter();
                aToolProblemDocumentsTableAdapter.Fill(aToolProblemDocumentsDataSet.toolproblemdocuments);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Get Tool Problem Documents Info " + Ex.Message);
            }

            return aToolProblemDocumentsDataSet;
        }
        public void UpdateToolProblemDocumentsDB(ToolProblemDocumentsDataSet aToolProblemDocumentsDataSet)
        {
            try
            {
                aToolProblemDocumentsTableAdapter = new ToolProblemDocumentsDataSetTableAdapters.toolproblemdocumentsTableAdapter();
                aToolProblemDocumentsTableAdapter.Update(aToolProblemDocumentsDataSet.toolproblemdocuments);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Update Tool Problem Documents DB " + Ex.Message);
            }
        }
        public FindToolProblemByDateRangeDataSet FindToolProblemByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindToolProblemByDateRangeDataSet = new FindToolProblemByDateRangeDataSet();
                aFindToolProblemByDateRangeTableAdapter = new FindToolProblemByDateRangeDataSetTableAdapters.FindToolProblemByDateRangeTableAdapter();
                aFindToolProblemByDateRangeTableAdapter.Fill(aFindToolProblemByDateRangeDataSet.FindToolProblemByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Find Tool Problems By Date Range " + Ex.Message);
            }

            return aFindToolProblemByDateRangeDataSet;
        }
        public FindToolProblemUpdateByProblemIDDataSet FindToolProblemUpdateByProblemID(int intProblemID)
        {
            try
            {
                aFindToolProblemUpdateByProblemIDDataSet = new FindToolProblemUpdateByProblemIDDataSet();
                aFindToolProblemUpdateByProblemIDTableAdapter = new FindToolProblemUpdateByProblemIDDataSetTableAdapters.FindToolProblemUpdateByProblemIDTableAdapter();
                aFindToolProblemUpdateByProblemIDTableAdapter.Fill(aFindToolProblemUpdateByProblemIDDataSet.FindToolProblemUpdateByProblemID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Find Tool Problem Update By Problem ID " + Ex.Message);
            }

            return aFindToolProblemUpdateByProblemIDDataSet;
        }
        public FindToolProblemByToolKeyDataSet FindToolProblemByToolKey(int intToolKey)
        {
            try
            {
                aFindToolProblemByToolKeyDataSet = new FindToolProblemByToolKeyDataSet();
                aFindToolProblemByToolKeyTableAdapter = new FindToolProblemByToolKeyDataSetTableAdapters.FindToolProblemByToolKeyTableAdapter();
                aFindToolProblemByToolKeyTableAdapter.Fill(aFindToolProblemByToolKeyDataSet.FindToolProblemByToolKey, intToolKey);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Find Tool Problem By Tool Key " + Ex.Message);
            }

            return aFindToolProblemByToolKeyDataSet;
        }
        public bool UpdateToolProblemRepairStatus(int intProblemID, bool blnRepaired, bool blnClosed)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateToolProblemRepairStatusTableAdapter = new UpdateToolProblemRepairStatusEntryTableAdapters.QueriesTableAdapter();
                aUpdateToolProblemRepairStatusTableAdapter.UpdateToolProblemRepairStatus(intProblemID, blnRepaired, blnClosed);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Update Tool Problem Repair Status " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool InsertToolProblemUpdate(int intProblemID, int intWarehouseEmployeeID, string strUpdateNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertToolProblemUpdateTableAdapter = new InsertToolProblemUpdateEntryTableAdapters.QueriesTableAdapter();
                aInsertToolProblemUpdateTableAdapter.InsertToolProblemUpdate(intProblemID, DateTime.Now, intWarehouseEmployeeID, strUpdateNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Insert Tool Problem Update " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertToolProblem(int intToolKey, DateTime datTransactionDate, int intEmployeeID, int intWarehouseEmployeeID, string strWarehouseStatement, bool blnRepairable, bool blnClosed)
        {
            bool blnFatalError = false;

            try
            {
                aInsertToolProblemTableAdapter = new InsertToolProblemEntryTableAdapters.QueriesTableAdapter();
                aInsertToolProblemTableAdapter.InsertToolProblem(intToolKey,datTransactionDate, intEmployeeID, intWarehouseEmployeeID, strWarehouseStatement, blnRepairable, blnClosed);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Insert Tool Problem " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ToolProblemUpdateDataSet GetToolProblemUpdateInfo()
        {
            try
            {
                aToolProblemUpdateDataSet = new ToolProblemUpdateDataSet();
                aToolProblemUpdateTableAdapter = new ToolProblemUpdateDataSetTableAdapters.toolproblemupdateTableAdapter();
                aToolProblemUpdateTableAdapter.Fill(aToolProblemUpdateDataSet.toolproblemupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Get Tool Problem Update Info " + Ex.Message);
            }

            return aToolProblemUpdateDataSet;
        }
        public void UpdateToolProblemUpdateDB(ToolProblemUpdateDataSet aToolProblemUpdateDataSet)
        {
            try
            {
                aToolProblemUpdateTableAdapter = new ToolProblemUpdateDataSetTableAdapters.toolproblemupdateTableAdapter();
                aToolProblemUpdateTableAdapter.Update(aToolProblemUpdateDataSet.toolproblemupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Update Tool Problem Update DB " + Ex.Message);
            }
        }
        public ToolProblemDataSet GetToolProblemInfo()
        {
            try
            {
                aToolProblemDataSet = new ToolProblemDataSet();
                aToolProblemTableAdapter = new ToolProblemDataSetTableAdapters.toolproblemTableAdapter();
                aToolProblemTableAdapter.Fill(aToolProblemDataSet.toolproblem);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Get Tool Problem Info " + Ex.Message);
            }

            return aToolProblemDataSet;
        }
        public void UpdateToolProblemDB(ToolProblemDataSet aToolProblemDataSet)
        {
            try
            {
                aToolProblemTableAdapter = new ToolProblemDataSetTableAdapters.toolproblemTableAdapter();
                aToolProblemTableAdapter.Update(aToolProblemDataSet.toolproblem);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Problem Class // Update Tool Problem DB " + Ex.Message);
            }
        }
    }
}
