using RoleplayGame.Scenarios;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IScenario scenario = new ClassRoomScenario();
            scenario.Setup();
            scenario.Run();
        }
    }
}
