﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.Domain;

namespace University.Data.DemoData
{
    public class CourseData
    {

        public CourseData()
        {
            _courses = new List<Course>()
            {
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "205", CourseName = "Surveying", Credits = 3, CourseId = "CE205" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "306", CourseName = "Advanced Surveying", Credits = 3, CourseId = "CE306" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "311", CourseName = "Environmental Engineering", Credits = 4, CourseId = "CE311" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "321", CourseName = "Structures I", Credits = 3, CourseId = "CE321" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "322", CourseName = "Structures II", Credits = 3, CourseId = "CE322" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "331", CourseName = "Enginering Properties of Soils", Credits = 4, CourseId = "CE331" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "337", CourseName = "Contruction Materials", Credits = 3, CourseId = "CE337" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "414", CourseName = "Pollution Engineering", Credits = 4, CourseId = "CE414" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "419", CourseName = "Civil Engineering Technology Systems", Credits = 3, CourseId = "CE419" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "425", CourseName = "Structural Design", Credits = 4, CourseId = "CE425" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "428", CourseName = "Engineering Hydrology", Credits = 4, CourseId = "CE428" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "442", CourseName = "Transportation Engineering", Credits = 3, CourseId = "CE442" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "451", CourseName = "Senior Project", Credits = 3, CourseId = "CE451" },
                new Course() { Department = UniversityData.Departments["CE"], DepartmentCode = "CE", CourseNumber = "452", CourseName = "Senior Project II", Credits = 3, CourseId = "CE452" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "101", CourseName = "General Chemistry", Credits = 4, CourseId = "CH101" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "102", CourseName = "General Chemistry II", Credits = 4, CourseId = "CH102" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "201", CourseName = "Analytical Chemistry", Credits = 4, CourseId = "CH201" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "251", CourseName = "Intermediate Chemistry Lab Procedures", Credits = 3, CourseId = "CH251" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "311", CourseName = "Organic Chemistry I", Credits = 4, CourseId = "CH311" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "312", CourseName = "Organic Chemistry II", Credits = 4, CourseId = "CH312" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "321", CourseName = "Physical Chemistry I", Credits = 4, CourseId = "CH321" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "322", CourseName = "Physical Chemistry II", Credits = 4, CourseId = "CH322" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "324", CourseName = "Glassblowing", Credits = 3, CourseId = "CH324" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "421", CourseName = "Advanced Inorganic Chemistry", Credits = 4, CourseId = "CH421" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "422", CourseName = "Advanced Analytical Chemistry", Credits = 3, CourseId = "CH422" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "431", CourseName = "Biochemistry I", Credits = 4, CourseId = "CH431" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "432", CourseName = "Biochemistry II", Credits = 4, CourseId = "CH432" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "441", CourseName = "Spectrometric Identification", Credits = 4, CourseId = "CH441" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "451", CourseName = "Senior Project", Credits = 3, CourseId = "CH451" },
                new Course() { Department = UniversityData.Departments["CH"], DepartmentCode = "CH", CourseNumber = "452", CourseName = "Senior Project II", Credits = 3, CourseId = "CH452" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "201", CourseName = "Chemical Process Analysis", Credits = 3, CourseId = "CM201" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "202", CourseName = "Chemical Transport", Credits = 3, CourseId = "CM202" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "311", CourseName = "Chemical Seperation Processes", Credits = 3, CourseId = "CM311" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "331", CourseName = "Thermodynamics", Credits = 3, CourseId = "CM331" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "403", CourseName = "Transport II", Credits = 3, CourseId = "CM403" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "409", CourseName = "Chemical Enginering Lab", Credits = 3, CourseId = "CM409" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "425", CourseName = "Polymers", Credits = 3, CourseId = "CM425" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "431", CourseName = "Process Dynamics and Control", Credits = 3, CourseId = "CM431" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "441", CourseName = "Chemical Process Design I", Credits = 3, CourseId = "CM441" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "442", CourseName = "Chemical Process Design II", Credits = 3, CourseId = "CM442" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "451", CourseName = "Senior Project", Credits = 3, CourseId = "CM451" },
                new Course() { Department = UniversityData.Departments["CM"], DepartmentCode = "CM", CourseNumber = "452", CourseName = "Senior Project II", Credits = 3, CourseId = "CM452" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "101", CourseName = "Introductory Programming", Credits = 3, CourseId = "CS101" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "102", CourseName = "Object Orientated Programming", Credits = 3, CourseId = "CS102" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "103", CourseName = "Programming Principles for Engineers", Credits = 3, CourseId = "CS103" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "104", CourseName = "Programming for Science Majors", Credits = 3, CourseId = "CS104" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "201", CourseName = "Data Structures and Analysis", Credits = 4, CourseId = "CS201" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "211", CourseName = "Systems Programming", Credits = 3, CourseId = "CS211" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "212", CourseName = "Database Systems", Credits = 3, CourseId = "CS212" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "307", CourseName = "Advanced Programming Techniques", Credits = 4, CourseId = "CS307" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "308", CourseName = "Internet Computing", Credits = 3, CourseId = "CS308" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "321", CourseName = "Operating Systems", Credits = 4, CourseId = "CS321" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "332", CourseName = "Networks and Network Protocols", Credits = 4, CourseId = "CS332" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "341", CourseName = "Software Engineering", Credits = 3, CourseId = "CS341" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "418", CourseName = "Systems Analysis", Credits = 4, CourseId = "CS418" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "424", CourseName = "Parallel Computing", Credits = 3, CourseId = "CS424" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "429", CourseName = "Computer Architecture", Credits = 4, CourseId = "CS429" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "437", CourseName = "Artificial Intelligence", Credits = 3, CourseId = "CS437" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "451", CourseName = "Senior Project I", Credits = 3, CourseId = "CS451" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "452", CourseName = "Senior Project I", Credits = 3, CourseId = "CS452" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "461", CourseName = "Advanced Algorithms", Credits = 4, CourseId = "CS461" },
                new Course() { Department = UniversityData.Departments["CS"], DepartmentCode = "CS", CourseNumber = "463", CourseName = "Theory of Computation", Credits = 3, CourseId = "CS463" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "201", CourseName = "Introductory Circuits", Credits = 4, CourseId = "EE201" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "202", CourseName = "Circuits II", Credits = 4, CourseId = "EE202" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "205", CourseName = "Circuits I for Science Majors", Credits = 4, CourseId = "EE205" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "209", CourseName = "Circuits for Engineers", Credits = 4, CourseId = "EE209" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "211", CourseName = "Digital Logic", Credits = 4, CourseId = "EE211" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "231", CourseName = "Electricity and Magnetism", Credits = 4, CourseId = "EE231" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "301", CourseName = "Microelectronic Circuits", Credits = 4, CourseId = "EE301" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "306", CourseName = "Circuits II for Science Majors", Credits = 4, CourseId = "EE306" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "314", CourseName = "Microprocessors", Credits = 4, CourseId = "EE314" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "315", CourseName = "Digital Design", Credits = 3, CourseId = "EE315" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "332", CourseName = "Signals and Waves", Credits = 4, CourseId = "EE332" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "347", CourseName = "Control Systems", Credits = 3, CourseId = "EE347" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "412", CourseName = "Digital Hardware Design II", Credits = 3, CourseId = "EE412" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "414", CourseName = "Computer Architecture", Credits = 3, CourseId = "EE414" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "423", CourseName = "Advanced Communications", Credits = 3, CourseId = "EE423" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "424", CourseName = "Digital Signal Processing", Credits = 3, CourseId = "EE424" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "434", CourseName = "Power Electronics", Credits = 3, CourseId = "EE434" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "435", CourseName = "Electronic Materials Science", Credits = 3, CourseId = "EE435" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "451", CourseName = "Senior Project", Credits = 3, CourseId = "EE451" },
                new Course() { Department = UniversityData.Departments["EE"], DepartmentCode = "EE", CourseNumber = "452", CourseName = "Senior Project II", Credits = 3, CourseId = "EE452" },
                new Course() { Department = UniversityData.Departments["LA"], DepartmentCode = "LA", CourseNumber = "101", CourseName = "College Writing", Credits = 3, CourseId = "LA101" },
                new Course() { Department = UniversityData.Departments["LA"], DepartmentCode = "LA", CourseNumber = "102", CourseName = "Presentations and Public Speaking", Credits = 3, CourseId = "LA102" },
                new Course() { Department = UniversityData.Departments["LA"], DepartmentCode = "LA", CourseNumber = "211", CourseName = "World History I", Credits = 3, CourseId = "LA211" },
                new Course() { Department = UniversityData.Departments["LA"], DepartmentCode = "LA", CourseNumber = "212", CourseName = "World History II", Credits = 3, CourseId = "LA212" },
                new Course() { Department = UniversityData.Departments["LA"], DepartmentCode = "LA", CourseNumber = "313", CourseName = "World History III", Credits = 3, CourseId = "LA313" },
                new Course() { Department = UniversityData.Departments["LA"], DepartmentCode = "LA", CourseNumber = "321", CourseName = "Microeconomics", Credits = 3, CourseId = "LA321" },
                new Course() { Department = UniversityData.Departments["LA"], DepartmentCode = "LA", CourseNumber = "322", CourseName = "Macroeconomics", Credits = 3, CourseId = "LA322" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "101", CourseName = "Calculus I", Credits = 4, CourseId = "MA101" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "102", CourseName = "Calculus II", Credits = 4, CourseId = "MA102" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "201", CourseName = "Differential Equations", Credits = 3, CourseId = "MA201" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "202", CourseName = "Calculus III", Credits = 3, CourseId = "MA202" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "211", CourseName = "Linear Algebra", Credits = 3, CourseId = "MA211" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "221", CourseName = "Probability and Statistics", Credits = 3, CourseId = "MA221" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "222", CourseName = "Engineering Statistics", Credits = 3, CourseId = "MA222" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "251", CourseName = "Statistics for Engineers", Credits = 3, CourseId = "MA251" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "311", CourseName = "Abstract Algebra", Credits = 3, CourseId = "MA311" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "321", CourseName = "Data Analysis", Credits = 3, CourseId = "MA321" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "331", CourseName = "Number Theory", Credits = 3, CourseId = "MA331" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "332", CourseName = "Numerical Analysis", Credits = 3, CourseId = "MA332" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "352", CourseName = "Advanced Engineering Mathematics", Credits = 3, CourseId = "MA352" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "363", CourseName = "Advanced Math for Chemistry Majors", Credits = 3, CourseId = "MA363" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "365", CourseName = "Advanced Math for Physics", Credits = 3, CourseId = "MA365" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "441", CourseName = "Complex Variables", Credits = 3, CourseId = "MA441" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "442", CourseName = "Partial Differential Equations", Credits = 3, CourseId = "MA442" },
                new Course() { Department = UniversityData.Departments["MA"], DepartmentCode = "MA", CourseNumber = "466", CourseName = "Mathematical Physics II", Credits = 3, CourseId = "MA466" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "201", CourseName = "Engineering Statics", Credits = 3, CourseId = "ME201" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "202", CourseName = "Engineering Dynamics", Credits = 3, CourseId = "ME202" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "205", CourseName = "Engineering Graphics and Systems", Credits = 3, CourseId = "ME205" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "311", CourseName = "Engineering Mechanics of Materials", Credits = 4, CourseId = "ME311" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "315", CourseName = "Mechanical Engineering Lab", Credits = 2, CourseId = "ME315" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "317", CourseName = "Kinematics and Machine Dynamics", Credits = 3, CourseId = "ME317" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "321", CourseName = "Thermodynamics I", Credits = 3, CourseId = "ME321" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "322", CourseName = "Heat Transfer", Credits = 3, CourseId = "ME322" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "331", CourseName = "Machine Design", Credits = 3, CourseId = "ME331" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "341", CourseName = "Fluid Mechanics", Credits = 4, CourseId = "ME341" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "414", CourseName = "Advanced Mechanics of Materials", Credits = 4, CourseId = "ME414" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "421", CourseName = "Thermodynamics II", Credits = 3, CourseId = "ME421" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "423", CourseName = "Fluid System Design", Credits = 3, CourseId = "ME423" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "432", CourseName = "Machine Design II", Credits = 3, CourseId = "ME432" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "447", CourseName = "Engineering for the Environment", Credits = 4, CourseId = "ME447" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "451", CourseName = "Senior Project I", Credits = 3, CourseId = "ME451" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "452", CourseName = "Senior Project II", Credits = 3, CourseId = "ME452" },
                new Course() { Department = UniversityData.Departments["ME"], DepartmentCode = "ME", CourseNumber = "461", CourseName = "Engineering Computation", Credits = 3, CourseId = "ME461" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "210", CourseName = "Principles of Accounting", Credits = 4, CourseId = "MG210" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "211", CourseName = "Business Finance", Credits = 4, CourseId = "MG211" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "311", CourseName = "Project Management", Credits = 3, CourseId = "MG311" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "321", CourseName = "Principles of Management", Credits = 3, CourseId = "MG321" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "323", CourseName = "Entrepreneurship", Credits = 2, CourseId = "MG323" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "324", CourseName = "Organizational Development", Credits = 3, CourseId = "MG324" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "327", CourseName = "Enterprise Planning", Credits = 3, CourseId = "MG327" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "331", CourseName = "Quality Management Systems", Credits = 3, CourseId = "MG331" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "341", CourseName = "Management Information Systems", Credits = 4, CourseId = "MG341" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "381", CourseName = "Marketing", Credits = 2, CourseId = "MG381" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "410", CourseName = "Scientific Methodology", Credits = 3, CourseId = "MG410" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "411", CourseName = "Engineering Management", Credits = 3, CourseId = "MG411" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "412", CourseName = "Business Strategy", Credits = 3, CourseId = "MG412" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "421", CourseName = "Engineering Management Ethics", Credits = 3, CourseId = "MG421" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "423", CourseName = "Business Plan Development", Credits = 3, CourseId = "MG423" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "424", CourseName = "Business Strategy Development", Credits = 3, CourseId = "MG424" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "425", CourseName = "International Business", Credits = 3, CourseId = "MG425" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "443", CourseName = "Business Analytics", Credits = 4, CourseId = "MG443" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "451", CourseName = "Senior Project", Credits = 3, CourseId = "MG451" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "452", CourseName = "Senior Project II", Credits = 3, CourseId = "MG452" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "461", CourseName = "Employment Law", Credits = 3, CourseId = "MG461" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "463", CourseName = "Government Regulations and Relations", Credits = 2, CourseId = "MG463" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "465", CourseName = "Patent and Intellecual Property Law", Credits = 2, CourseId = "MG465" },
                new Course() { Department = UniversityData.Departments["MG"], DepartmentCode = "MG", CourseNumber = "471", CourseName = "Advanced Business Communication", Credits = 3, CourseId = "MG471" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "101", CourseName = "Physics I", Credits = 3, CourseId = "PH101" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "102", CourseName = "Physcis II", Credits = 3, CourseId = "PH102" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "202", CourseName = "Modern Physics", Credits = 3, CourseId = "PH202" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "211", CourseName = "Mechanics", Credits = 3, CourseId = "PH211" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "321", CourseName = "Electricity and Magnetism", Credits = 3, CourseId = "PH321" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "322", CourseName = "Electricity and Magnetism II", Credits = 3, CourseId = "PH322" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "331", CourseName = "Thermodynamics", Credits = 3, CourseId = "PH331" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "341", CourseName = "Modern Physics II", Credits = 3, CourseId = "PH341" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "381", CourseName = "Advanced Physics Lab", Credits = 3, CourseId = "PH381" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "441", CourseName = "Quantum Mechanics", Credits = 3, CourseId = "PH441" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "445", CourseName = "Nuclear Physics", Credits = 3, CourseId = "PH445" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "451", CourseName = "Solid State Physics", Credits = 3, CourseId = "PH451" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "461", CourseName = "Computational Physics", Credits = 3, CourseId = "PH461" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "471", CourseName = "Senior Project I", Credits = 3, CourseId = "PH471" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "472", CourseName = "Senior Project II", Credits = 3, CourseId = "PH472" },
                new Course() { Department = UniversityData.Departments["PH"], DepartmentCode = "PH", CourseNumber = "482", CourseName = "Environmental Physics", Credits = 3, CourseId = "PH482" }
            };
        }


        private static List<Course> _courses = new List<Course>();


        public Course this[string courseId]
        {
            get => _courses.FirstOrDefault(c => c.CourseId == courseId);
        }


        public List<Course> AllCourses
        {
            get => _courses.ToList();
        }
    }
}