using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTO;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container
{
    public static class ContainerModule
    {
       public static void ContainerDependency(this IServiceCollection services)
       {
            services.AddScoped<ICommentService, CommentManager>(); 
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IContacUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfService, PdfManager>();

       }

        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
