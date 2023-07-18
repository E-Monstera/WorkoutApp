using WorkoutApp.Models;
using WorkoutApp.Services.Interfaces;

namespace WorkoutApp.Services
{
    public class ExcerciseService : IExcerciseService
    {
        public ExcerciseService() { }


        public async Task<List<Excercise>> GetAllNonCustomExcercises()
        {
            return new List<Excercise>()
            {
                new Excercise("Bicep Curls", false),
                new Excercise("Tricep Dips", false),
                new Excercise("Squats", false)
            };
        }
    }
}
