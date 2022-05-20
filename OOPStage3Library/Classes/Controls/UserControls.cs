using OOPStage3.Classes.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOPStage3.Classes.Controls
{
    [Serializable]
    public class UserControls
    {
        private List<User> _people = new();
        private List<Grade> _grades = new();
        private Dictionary<string, List<string>> _subjects = new();
        // interface za da otdelq logikata 
        public void AddUser(User person)
        {
            string[] info = person.GetBaseInfo();
            if (!_people.Any(u => u.GetBaseInfo()[0] == info[0] && info[1] == u.GetBaseInfo()[1]))
                _people.Add(person);
        }
        public User GetUser(string name, string password)
        {
            return _people
                   .SingleOrDefault(u => u.GetBaseInfo()[0] == name && u.GetBaseInfo()[1] == password);
        }
        public List<Student> FindStudents(List<string> studentID)
        {
            List<Student> students = new();
            foreach (var person in _people)
                if (person is Student)
                    foreach (string id in studentID)
                        if (id == person.GetInfo()[0])
                            students.Add(person as Student);

            return students;
        }
        public List<Student> GetAllStudents()
        {
            List<Student> allstudents = new();
            foreach(var person in _people)
                if(person is Student)
                    allstudents.Add(person as Student);
            return allstudents;
        }
        public List<Parent> GetAllParents()
        {
            List<Parent> allparents = new();
            foreach (var person in _people)
            {
                if (person is Parent)
                    allparents.Add(person as Parent);
            }
            return allparents;
        }
        public List<Professor> GetAllProfessors()
        {
            List<Professor> allprofessors = new();
            foreach (var person in _people)
            {
                if (person is Professor)
                    allprofessors.Add(person as Professor);
            }
            return allprofessors;
        }
        public void SaveUserData()
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("data", FileMode.Create))
            {
                formatter.Serialize(fs, _people);
                fs.Close();
                Debug.WriteLine("Users written");
            }
        }
        public void SaveGradesData()
        {
            IFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("gradesData", FileMode.Create))
            {
                formatter.Serialize(fs, _grades);
                fs.Close();
                Debug.WriteLine("Grades written");
            }
        }
        public void SaveCourseData()
        {
            IFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("subjectsData", FileMode.Create))
            {
                formatter.Serialize(fs, _subjects);
                fs.Close();
            }
        }
        public void GetUserData()
        {

            if (File.Exists("data"))
            {
                IFormatter formatter = new BinaryFormatter();
                using (var fs = new FileStream("data", FileMode.Open))
                {
                    _people = (List<User>)formatter.Deserialize(fs);
                    fs.Close();
                    Debug.WriteLine("Userdata read");
                }
            }

        }
        public void GetGradesData()
        {
            if (File.Exists("gradesData"))
            {
                IFormatter formatter = new BinaryFormatter();
                using (var fs = new FileStream("gradesData", FileMode.Open))
                {
                    _grades = (List<Grade>)formatter.Deserialize(fs);
                    fs.Close();
                }
            }

        }
        public void GetCourseData()
        {
            if (File.Exists("subjectsData"))
            {
                IFormatter formatter = new BinaryFormatter();
                using (var fs = new FileStream("subjectsData", FileMode.Open))
                {
                    _subjects = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
                    fs.Close();
                }
            }
        }
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
        public List<Grade> GetGrades(string paramater)
        {
            List<Grade> grades = _grades
                .Where(x => x.OwnerID == paramater || x.GradedBy == paramater)
                .ToList();
            return grades;
        }
        public List<string> GetSubjects(string course)
        {
            List<string> subjects = new();
            if (_subjects.TryGetValue(course, out var subject))
                return subject;

            return subjects;
        }
        public List<Grade> GetAllGrades()
        {
            return _grades;
        }
        public void AddCourse(string key, List<string> subjects)
        {
            _subjects.Add(key, subjects);
        }
    }
}
