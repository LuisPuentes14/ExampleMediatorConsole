using ExampleMediatorConsole;

internal class Program
{
    private static void Main(string[] args)
    {

        Mediator mediator = new Mediator();

        IColleague oPepe = new User(mediator);
        IColleague oAdmin = new UserAdmin(mediator);

        mediator.Add(oPepe);
        mediator.Add(oAdmin);

        oPepe.Communicate("Administrador tengo un problema");
        oAdmin.Communicate("Quentame que sucede");


    }
}