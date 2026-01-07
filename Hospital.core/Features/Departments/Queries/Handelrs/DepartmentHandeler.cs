using AutoMapper;
using Hospital.core.Bases;
using Hospital.core.Features.Departments.Queries.Models;
using Hospital.core.Features.Departments.Queries.Response;
using Hospital.core.Features.Doctors.Queries.Models;
using Hospital.Infrustructure.Data;
using Hospital.Service.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Departments.Queries.Handelrs
{
    public class DepartmentHandeler : ResponseHandler, IRequestHandler<GetDepartmentQuery,Response<List<DepartmentResponse>>>,
                                                       IRequestHandler<GetDepartmentByIDQuery,DepartmentResponse>

    {
        private readonly ApplicationDBcontext _context;
        private readonly IRepositoryService<Department> _departmentrepositoryService;
        private readonly IMapper _mapper;

        public DepartmentHandeler(ApplicationDBcontext context, IRepositoryService<Department> DepartmentrepositoryService, IMapper mapper)
        {
            _context = context;
            _departmentrepositoryService = DepartmentrepositoryService;
            _mapper = mapper;
        }
        public async Task<Response<List<DepartmentResponse>>> Handle(GetDepartmentQuery request, CancellationToken cancellationToken)
        {
            var departments =await _departmentrepositoryService.GetAsync(tracked: false, cancellationToken: cancellationToken);

            var departmentMapper = _mapper.Map<List<DepartmentResponse>>(departments);

            return Success(departmentMapper);
        }

        public async Task<DepartmentResponse> Handle(GetDepartmentByIDQuery request, CancellationToken cancellationToken)
        {
            var departmant =await _departmentrepositoryService.GetOneAsync(d => d.Id == request.Id, cancellationToken: cancellationToken);

            if (departmant is null)
                return null;

            var result = _mapper.Map<DepartmentResponse>(departmant);

            return result;

        }
    }
}
