using ServiceStack;

namespace TemplateViewPage.ServiceModel
{
    [Route("/database")]
    [Route("/database/{Name}")]
    public class Database : IReturn<DatabaseResponse>
    {
        public string Name { get; set; }
    }

    public class DatabaseResponse
    {
        public string DatabaseUrl { get; set; }
    }
}
