using System.Data;

namespace MyCv.Library
{
    static class clsData
    {
        private static DataSet myCvDataSet = null;
        private static DataSet myCvDataSetTemp = null;

        public static DataTable Projects { get { return myCvDataSet.Tables["Projects"]; } }
        public static DataTable ProfileImage { get { return myCvDataSet.Tables["ProfileImage"]; } }
        public static DataTable PersonalInfo { get { return myCvDataSet.Tables["PersonalInfo"]; } }
        public static DataTable Education { get { return myCvDataSet.Tables["Education"]; } }
        public static DataTable Certificates { get { return myCvDataSet.Tables["Certificates"]; } }
        public static DataTable WorkExperience { get { return myCvDataSet.Tables["WorkExperience"]; } }
        public static DataTable Skills { get { return myCvDataSet.Tables["Skills"]; } }
        public static DataTable CoverLetters { get { return myCvDataSet.Tables["CoverLetters"]; } }

        public static void Load()
        {
            CreateDataSet();
        }

        private static void CreateDataSet()
        {
            //dataSet
            myCvDataSet = new DataSet("MyCv");

            //tables
            DataTable projects = new DataTable("Projects");
            DataTable profileImage = new DataTable("ProfileImage");
            DataTable personalInfo = new DataTable("PersonalInfo");
            DataTable education = new DataTable("Education");
            DataTable certificates = new DataTable("Certificates");
            DataTable workExperience = new DataTable("WorkExperience");
            DataTable skills = new DataTable("Skills");
            DataTable coverLetters = new DataTable("CoverLetters");

            //projects
            projects.Columns.Add("ID", typeof(int));
            projects.Columns.Add("Name", typeof(string));

            projects.PrimaryKey = new DataColumn[] { projects.Columns["ID"] };
            projects.Columns["ID"].AutoIncrementSeed = 1;
            projects.Columns["ID"].AutoIncrementStep = 1;
            projects.Columns["ID"].AutoIncrement = true;
            projects.Columns["ID"].Unique = true;

            //profileImage
            profileImage.Columns.Add("ID", typeof(int));
            profileImage.Columns.Add("ProjectID", typeof(int));
            profileImage.Columns.Add("Visible", typeof(bool));

            profileImage.PrimaryKey = new DataColumn[] { profileImage.Columns["ID"] };
            profileImage.Columns["ID"].AutoIncrementSeed = 1;
            profileImage.Columns["ID"].AutoIncrementStep = 1;
            profileImage.Columns["ID"].AutoIncrement = true;
            profileImage.Columns["ID"].Unique = true;

            //personalInfo
            personalInfo.Columns.Add("ID", typeof(int));
            personalInfo.Columns.Add("ProjectID", typeof(int));
            personalInfo.Columns.Add("Name", typeof(string));
            personalInfo.Columns.Add("LastName", typeof(string));
            personalInfo.Columns.Add("DateOfBirth", typeof(string));
            personalInfo.Columns.Add("PhoneNumber", typeof(string));
            personalInfo.Columns.Add("Email", typeof(string));
            personalInfo.Columns.Add("Title", typeof(string));
            personalInfo.Columns.Add("BrieflyAboutYourself", typeof(string));
            personalInfo.Columns.Add("Visible", typeof(bool));

            personalInfo.PrimaryKey = new DataColumn[] { personalInfo.Columns["ID"] };
            personalInfo.Columns["ID"].AutoIncrementSeed = 1;
            personalInfo.Columns["ID"].AutoIncrementStep = 1;
            personalInfo.Columns["ID"].AutoIncrement = true;
            personalInfo.Columns["ID"].Unique = true;

            //education
            education.Columns.Add("ID", typeof(int));
            education.Columns.Add("ProjectID", typeof(int));
            education.Columns.Add("EducationLevel", typeof(string));
            education.Columns.Add("Name", typeof(string));
            education.Columns.Add("Attended", typeof(string));
            education.Columns.Add("Title", typeof(string));
            education.Columns.Add("Visible", typeof(bool));

            education.PrimaryKey = new DataColumn[] { education.Columns["ID"] };
            education.Columns["ID"].AutoIncrementSeed = 1;
            education.Columns["ID"].AutoIncrementStep = 1;
            education.Columns["ID"].AutoIncrement = true;
            education.Columns["ID"].Unique = true;

            //certificates
            certificates.Columns.Add("ID", typeof(int));
            certificates.Columns.Add("ProjectID", typeof(int));
            certificates.Columns.Add("Name", typeof(string));
            certificates.Columns.Add("Attended", typeof(string));
            certificates.Columns.Add("Visible", typeof(bool));

            certificates.PrimaryKey = new DataColumn[] { certificates.Columns["ID"] };
            certificates.Columns["ID"].AutoIncrementSeed = 1;
            certificates.Columns["ID"].AutoIncrementStep = 1;
            certificates.Columns["ID"].AutoIncrement = true;
            certificates.Columns["ID"].Unique = true;

            //workExperience
            workExperience.Columns.Add("ID", typeof(int));
            workExperience.Columns.Add("ProjectID", typeof(int));
            workExperience.Columns.Add("Name", typeof(string));
            workExperience.Columns.Add("Position", typeof(string));
            workExperience.Columns.Add("Attended", typeof(string));
            workExperience.Columns.Add("Description", typeof(string));
            workExperience.Columns.Add("Visible", typeof(bool));

            workExperience.PrimaryKey = new DataColumn[] { workExperience.Columns["ID"] };
            workExperience.Columns["ID"].AutoIncrementSeed = 1;
            workExperience.Columns["ID"].AutoIncrementStep = 1;
            workExperience.Columns["ID"].AutoIncrement = true;
            workExperience.Columns["ID"].Unique = true;

            //skill
            skills.Columns.Add("ID", typeof(int));
            skills.Columns.Add("ProjectID", typeof(int));
            skills.Columns.Add("SkillType", typeof(string));
            skills.Columns.Add("Name", typeof(string));
            skills.Columns.Add("Visible", typeof(bool));

            skills.PrimaryKey = new DataColumn[] { skills.Columns["ID"] };
            skills.Columns["ID"].AutoIncrementSeed = 1;
            skills.Columns["ID"].AutoIncrementStep = 1;
            skills.Columns["ID"].AutoIncrement = true;
            skills.Columns["ID"].Unique = true;

            //coverLetter
            coverLetters.Columns.Add("ID", typeof(int));
            coverLetters.Columns.Add("ProjectID", typeof(int));
            coverLetters.Columns.Add("Dear", typeof(string));
            coverLetters.Columns.Add("Content", typeof(string));
            coverLetters.Columns.Add("WithRespect", typeof(string));
            coverLetters.Columns.Add("Singature", typeof(string));
            coverLetters.Columns.Add("Visible", typeof(bool));

            coverLetters.PrimaryKey = new DataColumn[] { coverLetters.Columns["ID"] };
            coverLetters.Columns["ID"].AutoIncrementSeed = 1;
            coverLetters.Columns["ID"].AutoIncrementStep = 1;
            coverLetters.Columns["ID"].AutoIncrement = true;
            coverLetters.Columns["ID"].Unique = true;

            //addTablesToDataSet
            myCvDataSet.Tables.Add(projects);
            myCvDataSet.Tables.Add(profileImage);
            myCvDataSet.Tables.Add(personalInfo);
            myCvDataSet.Tables.Add(education);
            myCvDataSet.Tables.Add(certificates);
            myCvDataSet.Tables.Add(workExperience);
            myCvDataSet.Tables.Add(skills);
            myCvDataSet.Tables.Add(coverLetters);

            //cloneDataSet
            myCvDataSetTemp = myCvDataSet.Clone();
        }
    }
}