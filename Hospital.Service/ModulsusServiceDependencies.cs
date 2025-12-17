using Hospital.Data.Models;
using Hospital.Infrustructure.Repositories;
using Hospital.Infrustructure.Repositories.IRepositories;
using Hospital.Service.Abstract;
using Hospital.Service.Impelementaion;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.Service
{
    public static class ModulsusServiceDependencies
    {
            public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
            {


            services.AddScoped<IRepositoryService<Doctor>, RepositoryService<Doctor>>();
            services.AddScoped<IRepositoryService<Appointment>, RepositoryService<Appointment>>();
            services.AddScoped<IRepositoryService<Attachment>, RepositoryService<Attachment>>();
            services.AddScoped<IRepositoryService<Bed>, RepositoryService<Bed>>();
            services.AddScoped<IRepositoryService<Department>, RepositoryService<Department>>();
            services.AddScoped<IRepositoryService<DoctorSpecialty>, RepositoryService<DoctorSpecialty>>();
            services.AddScoped<IRepositoryService<Insurance>, RepositoryService<Insurance>>();
            services.AddScoped<IRepositoryService<Invoice>, RepositoryService<Invoice>>();
            services.AddScoped<IRepositoryService<InvoiceItem>, RepositoryService<InvoiceItem>>();
            services.AddScoped<IRepositoryService<LabOrder>, RepositoryService<LabOrder>>();
            services.AddScoped<IRepositoryService<LabOrderItem>, RepositoryService<LabOrderItem>>();
            services.AddScoped<IRepositoryService<LabResult>, RepositoryService<LabResult>>();
            services.AddScoped<IRepositoryService<Medication>, RepositoryService<Medication>>();
            services.AddScoped<IRepositoryService<Patient>, RepositoryService<Patient>>();
            services.AddScoped<IRepositoryService<PharmacyStock>, RepositoryService<PharmacyStock>>();
            services.AddScoped<IRepositoryService<Prescription>, RepositoryService<Prescription>>();
            services.AddScoped<IRepositoryService<PrescriptionItem>, RepositoryService<PrescriptionItem>>();
            services.AddScoped<IRepositoryService<Room>, RepositoryService<Room>>();
            services.AddScoped<IRepositoryService<Specialty>, RepositoryService<Specialty>>();
            services.AddScoped<IRepositoryService<Visit>, RepositoryService<Visit>>();
            services.AddScoped<IRepositoryService<VisitNote>, RepositoryService<VisitNote>>();
            services.AddScoped<IRepositoryService<ApplicationUserOTP>, RepositoryService<ApplicationUserOTP>>();
            return services;
            }
        }
    }
