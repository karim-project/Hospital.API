
using Hospital.Infrustructure.Repositories;
using Hospital.Infrustructure.Repositories.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.Infrustructure
{
    public static class ModulsusingInfrustructureDependencies
    {

        public static   IServiceCollection AddInfrustructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Doctor>, Repository<Doctor>>();
            services.AddScoped<IRepository<Appointment>, Repository<Appointment>>();
            services.AddScoped<IRepository<Attachment>, Repository<Attachment>>();
            services.AddScoped<IRepository<Bed>, Repository<Bed>>();
            services.AddScoped<IRepository<Department>, Repository<Department>>();
            services.AddScoped<IRepository<DoctorSpecialty>, Repository<DoctorSpecialty>>();
            services.AddScoped<IRepository<Insurance>, Repository<Insurance>>();
            services.AddScoped<IRepository<Invoice>, Repository<Invoice>>();
            services.AddScoped<IRepository<InvoiceItem>, Repository<InvoiceItem>>();
            services.AddScoped<IRepository<LabOrder>, Repository<LabOrder>>();
            services.AddScoped<IRepository<LabOrderItem>, Repository<LabOrderItem>>();
            services.AddScoped<IRepository<LabResult>, Repository<LabResult>>();
            services.AddScoped<IRepository<Medication>, Repository<Medication>>();
            services.AddScoped<IRepository<Patient>, Repository<Patient>>();
            services.AddScoped<IRepository<PharmacyStock>, Repository<PharmacyStock>>();
            services.AddScoped<IRepository<Prescription>, Repository<Prescription>>();
            services.AddScoped<IRepository<PrescriptionItem>, Repository<PrescriptionItem>>();
            services.AddScoped<IRepository<Room>, Repository<Room>>();
            services.AddScoped<IRepository<Specialty>, Repository<Specialty>>();
            services.AddScoped<IRepository<Visit>, Repository<Visit>>();
            services.AddScoped<IRepository<VisitNote>, Repository<VisitNote>>();
            services.AddScoped<IRepository<ApplicationUserOTP>, Repository<ApplicationUserOTP>>();

            return services;
        }



    }
}
