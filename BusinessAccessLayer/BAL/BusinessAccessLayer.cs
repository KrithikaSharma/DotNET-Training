using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BusinessAccessLayer
    {
        
        DataAccessLayer obj = new DataAccessLayer();
        DataSet ds = new DataSet();
        public SqlDataReader loginDetails(string name, string pwd)
        {
            return obj.LoginDetails(name, pwd);
        }
        public SqlDataReader AdminForgorPwd(string email)
        {
            return obj.AdminForgorPwd(email);
        }
        public SqlDataReader TrainerForgorPwd(string email)
        {
            return obj.TrainerForgorPwd(email);
        }
        public SqlDataReader EmployeeForgorPwd(string email)
        {
            return obj.EmployeeForgorPwd(email);
        }
        public SqlDataReader TrainerLoginDetails(string name, string pwd)
        {
            return obj.TrainerLoginDetails(name, pwd);
        }
        public SqlDataReader EmployeeLoginDetails(string name, string pwd)
        {
            return obj.EmployeeLoginDetails(name, pwd);
        }
        public int Addemp(string fname, string lname, string uname, string pwd, string dob,string gender, string address, string ph, string email)
        {
            int i = obj.Addemp(fname,lname,uname,pwd,dob,gender,address,ph,email);
            return i;
        }
        public int Addtrainer(string fname, string lname, string uname, string pwd, string dob,string gender, string address, string ph, string email)
        {
            int i = obj.Addtrainer(fname, lname, uname, pwd, dob,gender, address, ph, email);
            return i;
        }
        public DataSet ViewEmpDetails()
        {
           return ds= obj.ViewEmpDetails();
            
        }
        public int updateEmp(string fname, string lname,string dob,string gender, string address, string ph, string email, string id)
        {
            int i = obj.updateEmp(fname, lname,dob,gender, address, ph, email, id);
            return i;
        }
        public int DeleteEmp(string id)
        {
            int i = obj.deleteEmp(id);
            return i;
        }
        public DataSet ViewTrainerAssigned()
        {
            return ds = obj.ViewTrainerAssigned();
        }
        public DataSet ViewTrainerDetails()
        {
            return ds = obj.ViewTrainerDetails();
        }
        public int updateTrainer(string fname, string lname,string dob,string gender, string address, string ph, string email, string id)
        {
            int i = obj.updateTrainer(fname, lname, dob,gender, address, ph, email, id);
            return i;
        }
        public int DeleteTrainer(string id)
        {
            int i = obj.deleteTrainer(id);
            return i;
        }
        public DataSet GetTrainers()
        {
            return ds = obj.GetTrainers();
        }
        public DataSet GetClasses()
        {
            return ds = obj.GetClasses();
        }
        public int updateAssignClasstoTrainer(string classname, string username)
        {
            int i = obj.updateAssignClasstoTrainer(classname, username);
            return i;
        }
        public int AssignClasstoTrainer(string trainername, string classname)
        {
            int i = obj.AssignClasstoTrainer(trainername, classname);
            return i;
        }
        public SqlDataReader GetTrainerDetails(string name)
        {
            SqlDataReader s = obj.GetTrainerDetails(name);
            return s;
        }
        public int updateTrainer2(string fname, string lname, string uname, string pwd, string dob, string gender,string address, string ph, string email, string uuname)
        {
            int i = obj.updateTrainer2(fname, lname, uname,pwd, dob,gender, address, ph, email, uuname);
            return i;
        }
        public DataSet ViewDepartments()
        {
            return ds = obj.ViewDepartments();
        }
        public int DeleteAssignTrainers(string id)
        {
            int i = obj.DeleteAssignTrainers(id);
            return i;
        }
        public SqlDataReader GetEmpDetails(string name)
        {
            SqlDataReader s = obj.GetEmpDetails(name);
            return s;
        }
        public int UploadResume(string resumee, string uname)
        {
            int i = obj.UploadResume(resumee, uname);
            return i;
        }
        public SqlDataReader DownloadResume(string uname)
        {
            SqlDataReader s = obj.DownloadResume(uname);
            return s;
        }
        public int AddSubject(string name)
        {
            int i = obj.AddSubject(name);
            return i;
        }
        public DataSet ViewSubject()
        {
            DataSet ds = obj.ViewSubject();
            return ds;
        }
        public int updateSubject(string name, string id)
        {
            int i=obj.updateSubject(name,id);
            return i;
        }
        public int DeleteSubject(string id)
        {
            int i = obj.DeleteSubject(id);
            return i;
        }
        public SqlDataReader Gettrainerss()
        {
            SqlDataReader i = obj.Gettrainerss();
            return i;
        }
        public SqlDataReader ViewSubjectss(string sname)
        {
            SqlDataReader i = obj.ViewSubjectss(sname);
            return i;
        }
        public int ScheduelandOrganizeTraining(string trainer, string sub,string date ,string time)
        {
            int i = obj.ScheduelandOrganizeTraining(trainer,sub,date, time);
            return i;
        }
        public DataSet viewAssignedTrainigsandTimings()
        {
            DataSet ds = obj.viewAssignedTrainigsandTimings();
            return ds;
        }
        public SqlDataReader ViewDept()
        {
            SqlDataReader sdr = obj.ViewDept();
            return sdr;
        }
        public SqlDataReader Viewemps()
        {
            SqlDataReader sdr = obj.Viewemps();
            return sdr;
        }
        public int AssignDept(string dept, string emp)
        {
            int i = obj.AssignDept(dept,emp);
            return i;
        }
        public DataSet ViewAssignDept(string name)
        {
            DataSet ds = obj.ViewAssignDept(name);
            return ds;
        }
        public DataSet Viewscheduledtrainings(string name)
        {
            DataSet ds = obj.Viewscheduledtrainings(name);
            return ds;
        }
        public DataTable ViewSubjectss()
        {
            DataTable dt = obj.ViewSubjectss();
            return dt;
        }
    }
}
