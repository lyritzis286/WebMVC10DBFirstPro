namespace SchoolApp.Services
{
    public class ApplicationService : IApplicationService
    {
        public ApplicationService(IUserService userService, ITeacherService teacherService)
        {
            UserService = userService;
            TeacherService = teacherService;
        }

        public IUserService UserService { get; }

        public ITeacherService TeacherService { get; }
    }
}
