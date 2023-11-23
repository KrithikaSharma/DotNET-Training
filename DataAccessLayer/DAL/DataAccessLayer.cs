using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayer
    {
        //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Talent.mdf;Connect Timeout=40");
        SqlConnection con = new SqlConnection("Data Source=ADMINRG-0T8NIDK;Database=Talent;integrated security=true");

        SqlCommand cmd = new SqlCommand();
        public SqlDataReader LoginDetails(string name, string pwd)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Admin where UserName='" + name + "' and Password='" + pwd + "'";
            cmd.Connection = con;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlDataReader AdminForgorPwd(string email)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Admin where Email='" + email + "'";
            cmd.Connection = con;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlDataReader TrainerForgorPwd(string email)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select UserName,Password from TraineDetails where Email='" + email + "'";
            cmd.Connection = con;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        
        public SqlDataReader EmployeeForgorPwd(string email)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select UserName,Password from EmployeeDetails where EMail='" + email + "'";
            cmd.Connection = con;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlDataReader TrainerLoginDetails(string name, string pwd)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TraineDetails where UserName='" + name + "' and Password='" + pwd + "'";
            cmd.Connection = con;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlDataReader EmployeeLoginDetails(string name, string pwd)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EmployeeDetails where UserName='" + name + "' and Password='" + pwd + "'";
            cmd.Connection = con;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        public int Addemp(string fname,string lname,string uname,string pwd,string dob,string gender,string address,string ph,string email)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into EmployeeDetails values('"+fname+"','"+lname+"','"+uname+"','"+pwd+"','"+dob+"','"+gender+"','"+address+"','"+ph+"','"+email+"','"+null+"')";
            cmd.Connection = con;
            int r=cmd.ExecuteNonQuery();
            return r;
             
        }
        string s = null;
        public int Addtrainer(string fname, string lname, string uname, string pwd, string dob,string gender, string address, string ph, string email)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into TraineDetails values('" + fname + "','" + lname + "','" + uname + "','" + pwd + "','" + dob + "','" + gender + "','" + address + "','" + ph + "','" + email + "')";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;

        }
        public DataSet ViewEmpDetails()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EmployeeDetails";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public int updateEmp(string fname,string lname,string dob,string gender,string address,string ph,string email,string id)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update EmployeeDetails set FirstName='" + fname + "',LastName='" + lname + "',DateOfBirth='" + dob + "',Gender='" + gender + "',Address='" + address + "',PhoneNumber='" + ph + "',EMail='" + email + "' where EmployeeId="+id+"";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public int deleteEmp(string id)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EmployeeDetails where EmployeeId="+id+"";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public DataSet ViewTrainerAssigned()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AssignToTrainer";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public DataSet ViewTrainerDetails()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TraineDetails";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public int updateTrainer(string fname, string lname,string dob,string gender,string address, string ph, string email, string id)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update TraineDetails set FirstName='" + fname + "',LastName='" + lname + "',DateOfBirth='" + dob + "',Gender='" + gender + "',Address='" + address + "',PhoneNumber='" + ph + "',EMail='" + email + "' where TraineeId=" + id + "";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public int updateAssignClasstoTrainer(string classname, string uname)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into  AssignToTrainer values('"+uname+"','"+classname+"')";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public int updateTrainer2(string fname, string lname, string uname, string pwd, string dob, string gender,string address, string ph, string email, string uuname)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update TraineDetails set FirstName='" + fname + "',LastName='" + lname + "',Password='" + pwd + "', DateOfBirth='" + dob + "',Gender='" + gender + "',Address='" + address + "',PhoneNumber='" + ph + "',EMail='" + email + "' where UserName='" + uuname + "'";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }

        public int deleteTrainer(string id)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TraineDetails where TraineeId=" + id + "";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public DataSet GetTrainers()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct(UserName) from TraineDetails";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public DataSet GetClasses()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct(SubjectName) from Subject";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public int AssignClasstoTrainer(string trainername,string classname)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into AssignToTrainer values('"+trainername+"','"+classname+"')";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }

        public SqlDataReader GetTrainerDetails(string name)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select TraineeId,FirstName,LastName,UserName,Password,DateOfBirth,Gender,Address,PhoneNumber,Email from TraineDetails where UserName='" + name + "'";
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlDataReader GetEmpDetails(string name)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select EmployeeId,FirstName,LastName,UserName,Password,DateOfBirth,Gender,Address,PhoneNumber,Email from EmployeeDetails where UserName='" + name + "'";
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        public int UploadResume(string resumee,string uname)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update EmployeeDetails set Resume='"+resumee+"' where UserName='"+uname+"'";
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public SqlDataReader DownloadResume(string uname)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Resume from EmployeeDetails where UserName='" + uname + "'";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public int AddSubject(string name)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Subject values('"+name+"')";
            cmd.Connection = con;
            int re = cmd.ExecuteNonQuery();
            return re;
        }
        public DataSet ViewSubject()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subject";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public int updateSubject(string name,string id)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Subject set SubjectName='"+name+"' where Id='"+id+"'";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public int DeleteSubject(string id)
        {
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Subject where ID='"+id+"'";
            cmd.Connection = con;
            int r = cmd.ExecuteNonQuery();
            return r;
        }
        public SqlDataReader Gettrainerss()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select UserName from TraineDetails";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader ViewSubjectss(string sname)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ClassName from AssignToTrainer where TrainerName='"+sname+"'";
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        public int ScheduelandOrganizeTraining(string trainer,string sub,string date,string time)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ScheduleAndOrganize values('" + trainer + "','" + sub + "','"+date+"','" + time + "')";
            cmd.Connection = con;
            int re = cmd.ExecuteNonQuery();
            return re;
        }
        public DataSet viewAssignedTrainigsandTimings()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ScheduleAndOrganize";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public SqlDataReader ViewDept()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Dept from Departments";
            cmd.Connection = con;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlDataReader Viewemps()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select UserName from EmployeeDetails";
            SqlDataReader sdr; cmd.Connection = con;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        public int AssignDept(string dept, string emp)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into AssignDept values('" + dept + "','" + emp + "')";
            cmd.Connection = con;
            int re = cmd.ExecuteNonQuery();
            return re;
        }
        public DataSet ViewDepartments()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Emp as Employee,Dept as Department from AssignDept";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;            
        }
        public int DeleteAssignTrainers(string id)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from AssignToTrainer where Id='"+id+"' ";
            cmd.Connection = con;
            int re = cmd.ExecuteNonQuery();
            return re;
        }
        public DataSet ViewAssignDept(string name)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Dept,Emp from AssignDept where Emp='" +name+ "'";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public DataSet Viewscheduledtrainings(string name)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ScheduleAndOrganize where Trainer='"+name+"'";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public DataTable ViewSubjectss()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subject";
            cmd.Connection = con;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
    }
}
