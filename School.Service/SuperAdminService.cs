﻿using School.Core;
using School.Core.Entities;
using School.Core.Exceptions;
using School.Core.Helpers;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;
using School.Infrastructure.Interfaces;
using System;
using Ecole = School.Core.Entities.School;

namespace School.Service
{
    public class SuperAdminService : ISuperAdminService
    {
        private readonly IGenericRepository<Ecole> _SchoolRepo;

        private readonly ISysParamValueRepository _SysParamRepo;

        private readonly IAdminRepo _AdminRepo;
        public SuperAdminService(IGenericRepository<Ecole> schoolRepo, ISysParamValueRepository sysParamRepo, IAdminRepo adminRepo)
        {
            _SchoolRepo = schoolRepo;
            _SysParamRepo = sysParamRepo;
            _AdminRepo = adminRepo;
        }
        public void CreateSchool(CreateSchoolReq request, int userId)
        {            
            if (string.IsNullOrEmpty(request.Name))
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.SCHOOL_NAME_ERROR_CODE) });

            _SchoolRepo.Insert(new Ecole { Name = request.Name, Description = request.Description, CreatedBy = userId });
            _SchoolRepo.Commit();
        }

        public string GeneratePassword()
        {
            Random random = new Random();
            string upper = ((char)random.Next('A', 'Z' + 1)).ToString();
            string lower = ((char)random.Next('a', 'z' + 1)).ToString();
            string specialChars = "@#$+*!?";
            string special = (specialChars[random.Next(specialChars.Length)]).ToString();
            string hash = DateTime.Now.ToString().HashPassword();

            return $"{upper}{lower}{special}{hash.Substring(0, 5)}";
        }

        public Admin Login(LoginReq request)
        {
            if(string.IsNullOrEmpty(request.Login) || string.IsNullOrEmpty(request.Password))
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_LOGIN_PASSWORD_ERROR_CODE) });

            request.Login = request.Login.Trim();
            var admin = _AdminRepo.FindByLogin(request.Login, request.Password.HashPassword());

            if(admin is null || !admin.IsSuper)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_LOGIN_PASSWORD_ERROR_CODE) });

            return admin;
        }
    }
}
