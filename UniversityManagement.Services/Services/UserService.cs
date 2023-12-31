﻿using AutoMapper;
using System.Text.RegularExpressions;
using System.Text;
using UniversityManagement.Entities.Models;
using UniversityManagement.Respositories.Infrastructures;
using UniversityManagement.Respositories.Models;
using UniversityManagement.Services.IServices;
using UniversityManagement.Services.Models;

namespace UniversityManagement.Services.Services
{
    public class UserService :IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public RefreshToken CheckRefreshToken(LoginResponseService model)
        {
            LoginResponse response = _mapper.Map<LoginResponse>(model);
            var refreshToken = _unitOfWork.userRepository.CheckRefreshToken(response);
            return refreshToken;
        }

        public void AddUser(User entity)
        {
            _unitOfWork.userRepository.AddTEntity(entity);
            _unitOfWork.Savechanges();
        }

        public void DeleteUser(User entity)
        {
            _unitOfWork.userRepository.DeleteTEntity(entity);
            _unitOfWork.Savechanges();
        }

        public void DeleteUser(int entityId)
        {
            _unitOfWork.userRepository.DeleteTEntity(entityId);
            _unitOfWork.Savechanges();
        }

        public User Find(Guid entityId)
        {
            var user = _unitOfWork.userRepository.Find(entityId);
            return user;
        }
        public async Task<LoginResponse> Login(LoginRequestService request)
        {
            LoginRequest response = _mapper.Map<LoginRequest>(request);
            var user = await _unitOfWork.userRepository.Login(response);
            return user;
        }

        public IEnumerable<User> GetAllEntities()
        {
            var user = _unitOfWork.userRepository.GetAllEntities();
            return user;
        }

        public async Task<User> Register(RegisterationRequestService registerationRequest)
        {
            RegisterationRequest response = _mapper.Map<RegisterationRequest>(registerationRequest);
            var user = await _unitOfWork.userRepository.Register(response);
            return user;
        }

        public void UpdateUser(User entity)
        {
            _unitOfWork.userRepository.UpdateTEntity(entity);
            _unitOfWork.Savechanges();
        }

        public IEnumerable<User> UserPagination(int pageSize, int PageIndex)
        {
            return _unitOfWork.userRepository.Pagination(pageSize, PageIndex);
        }
        public async Task<bool> IsUniqueUser(string username)
        {
            bool result = await _unitOfWork.userRepository.IsUniqueUser(username);
            return result;
        }

        public async Task<bool> IsUniqueEmail(string email)
        {
            bool result = await _unitOfWork.userRepository.IsUniqueEmail(email);
            return result;
        }

        public DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
        {
            var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();
            return dateTimeInterval;
        }

        public void UpdateToken(RefreshToken model)
        {
            _unitOfWork.userRepository.UpdateToken(model);
        }

        public long CreateUnixTime(LoginResponseService model)
        {
            LoginResponse response = _mapper.Map<LoginResponse>(model);
            return _unitOfWork.userRepository.CreateUnixTime(response);
        }

        public async Task<string> CheckPasswordStrength(string password)
        {
            StringBuilder sb = new StringBuilder();
            if (password.Length < 6)
            {
                sb.Append("Minimum password length should be 6" + Environment.NewLine);
            }
            if (!(Regex.IsMatch(password, "[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[0-9]")))
            {
                sb.Append("Password should be Alphanumeric" + Environment.NewLine);
            }
            if (!Regex.IsMatch(password, "[<,>,@,!,#,$,%,^,&,*,(,),_,+,\\,[,\\],{,},?,:,;,|,',\\,.,/,~,`,-,=]"))
            {
                sb.Append("Password should contain special chars" + Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
