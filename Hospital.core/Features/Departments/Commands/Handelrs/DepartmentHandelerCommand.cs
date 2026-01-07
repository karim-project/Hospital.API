using AutoMapper;
using Hospital.core.Bases;
using Hospital.core.Features.Departments.Commands.Models;
using Hospital.Service.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.core.Features.Departments.Commands.Handelrs
{
    public class DepartmentHandelerCommand : ResponseHandler,
                                             IRequestHandler<AddDepartmentCommand , Response<string>>,
                                             IRequestHandler<EditDepartmentCommand , Response<string>>,
                                             IRequestHandler<DeleteDepartmentCommand , Response<string>>
    {
        private readonly IRepositoryService<Department> _departmentRepositoryService;
        private readonly IMapper _mapper;

        public DepartmentHandelerCommand(IRepositoryService<Department> repositoryService, IMapper mapper)
        {
            _departmentRepositoryService = repositoryService;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
        {
            var departmentMapper = _mapper.Map<Department>(request);

            var result = await  _departmentRepositoryService.AddAsync(departmentMapper, cancellationToken);
           await _departmentRepositoryService.CommitAsync(cancellationToken);

            if (result is null)
                return new Response<string>("exit");
            else if (result is not null)
                return Created("Add succfully");

            return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department =await _departmentRepositoryService.GetOneAsync(d => d.Id == request.Id);

            if(department is null)
                return NotFound<string>("Department is not found");

            _mapper.Map(request , department);

            _departmentRepositoryService.Update(department);
           await _departmentRepositoryService.CommitAsync(cancellationToken);

            return Success("Department updated successfully");
        }

        public async Task<Response<string>> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department =await _departmentRepositoryService.GetOneAsync(d=>d.Id == request.Id);

            if(department is null)
                return NotFound<string>("Department is not found");

             _departmentRepositoryService.Delete(department);
            await _departmentRepositoryService.CommitAsync(cancellationToken);

            return Success("Department Delete successfully");
        }
    }
}
