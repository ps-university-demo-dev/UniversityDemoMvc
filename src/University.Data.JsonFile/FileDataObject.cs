using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using University.Core.Domain;

namespace University.Data.JsonFile
{
    public class FileDataObject
    {

        public FileDataObject(String dataDirectory)
        {
            _dataDirectory = dataDirectory;
        }

        private String _dataDirectory;



        private List<T> ReadDataFile<T>(String filename)
        {
            String filePath = Path.Combine(_dataDirectory, filename);
            String json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<T>>(json);
        }


        public List<Grade> ReadGradesFile() => ReadDataFile<Grade>("Grades.json");

        public List<Semester> ReadSemestersFile() => ReadDataFile<Semester>("Semesters.json");

        public List<Term> ReadTermsFile() => ReadDataFile<Term>("Terms.json");

        public List<Department> ReadDepartmentsFile() => ReadDataFile<Department>("Departments.json");






    }
}
