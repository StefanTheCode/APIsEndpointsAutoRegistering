namespace APIsEndpointsAutoRegistering
{
    public class Program
    {
        //This is some test for qodo merge tool
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddOpenApi();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.RegisterAllEndpoints();

            app.Run();
        }
    }
}