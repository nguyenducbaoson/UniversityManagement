﻿using UniversityManagement.Entities.Models;

namespace UniversityManagement.Respositories.IRespositories
{
    public interface ISubjectRepository:IBaseRepository<Subject>
    {
        List<Subject> GetAllSubjectByStudent(string studentName);
        List<Subject> GetAllSubjectByStudentId(Guid StudentId);

        public Subject GetSubjectByName(string name);

        public List<Subject> GetSubjectByTeacher(string teacherName);
        public IEnumerable<Subject> GetAllEntities();

    }
}
