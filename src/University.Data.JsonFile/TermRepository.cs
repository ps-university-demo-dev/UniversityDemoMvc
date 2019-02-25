using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.JsonFile
{
    public class TermRepository : ITermRepository
    {

        public TermRepository(String dataDirectory)
        {
            _dataDirectory = dataDirectory;
        }

        private String _dataDirectory;




        public List<Term> LoadTerms()
        {
            FileDataObject fdo = new FileDataObject(_dataDirectory);

            var semesters = fdo.ReadSemestersFile();
            var rawTerms = fdo.ReadTermsFile();

            var query =
                from rawTerm in rawTerms
                join semester in semesters on rawTerm.SemesterCode equals semester.Code
                select new Term{ TermCode = rawTerm.TermCode, SemesterCode = semester.Code, Year = rawTerm.Year, Semester = semester };

            return query.ToList();
        }

    }
}
