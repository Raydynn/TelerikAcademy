namespace ConsoleApplication3
{
    // I am not sure if we need this, but too scared to delete.
    internal class BusinessLogicService
    {
        public void Execute(ConsoleReaderProvider reader)
        {
            var engine = new Engine(reader);
            engine.EngineStart();
        }
    }
}
