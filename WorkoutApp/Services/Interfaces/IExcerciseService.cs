using WorkoutApp.Models;

namespace WorkoutApp.Services.Interfaces
{
    public interface IExcerciseService
    {
        Task<List<Excercise>> GetAllNonCustomExcercises();
    }
}
