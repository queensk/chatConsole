namespace Models
{
    public class User: BaseModel
    {
        User(int Id, string? CreatedAt, string? UpdatedAt, string? Name, string? Email, string? Password) : base()
        {
            
        }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}