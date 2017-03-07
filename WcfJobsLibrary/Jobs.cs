using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfJobsLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Jobs" in both code and config file together.
    public class Jobs : IJobs
    {
        public DataSet GetJobs()
        {
            //-- declare new dataset 
            DataSet ds = new DataSet("shop");

            //-- declare new datatable
            DataTable toysTable = new DataTable("toys");

            //-- add new columns
            toysTable.Columns.Add("ID", typeof(int));
            toysTable.Columns.Add("Title", typeof(string));
            
            //-- create new row
            DataRow toyRow = toysTable.NewRow();
            toyRow["ID"] = 1;
            toyRow["Title"] = "Toy1";

            //-- add new row
            toysTable.Rows.Add(toyRow);

            //-- add new table
            ds.Tables.Add(toysTable);

            //-- return dataset
            return ds;
        }

        public Job GetJobInfo(int jobid)
        {
            //-- initialize new job
            Job jobObj = new Job();
            jobObj.Description = "returned job description";
            jobObj.MinLevel = -1;
            jobObj.MaxLevel = 1024;

            //-- return job object
            return jobObj;
        }
    }
}
