using System;
using System.Collections.Generic;
using System.Text;
using VRA.Dto;
using VRA.DataAccess.Entities;

namespace VRA.BusinessLayer.Converters
{
    public class DtoConverter
    {
        public static TeacherDto Convert(Teacher teacher)
        {  
            if (teacher == null)
                return null;
            TeacherDto teacherDto = new TeacherDto();
            teacherDto.TeacherId = teacher.TeacherID;
            teacherDto.SecondName = teacher.SecondName;
            teacherDto.FirstName = teacher.FirstName;
            teacherDto.MiddleName = teacher.MiddleName;
            teacherDto.AcademicDegree = teacher.AcademicDegree;
            teacherDto.Position = teacher.Position;
            teacherDto.Experience = teacher.Experience;
            return teacherDto;
        }

        public static Teacher Convert(TeacherDto teacherDto)
        {
            if (teacherDto == null)
                return null;
            Teacher teacher = new Teacher();
            teacher.TeacherID = teacherDto.TeacherId;
            teacher.SecondName = teacherDto.SecondName;
            teacher.FirstName = teacherDto.FirstName;
            teacher.MiddleName = teacherDto.MiddleName;
            teacher.AcademicDegree = teacherDto.AcademicDegree;
            teacher.Position = teacherDto.Position;
            teacher.Experience = teacherDto.Experience;
            return teacher;
        }

        public static IList<TeacherDto> Convert(IList<Teacher> teachers)
        {
            if (teachers == null)
                return null;
            IList<TeacherDto> teacherDtos = new List<TeacherDto>();
            foreach (var teacher in teachers)
            {
                teacherDtos.Add(Convert(teacher));
            }
            return teacherDtos;
        }
    }
}
