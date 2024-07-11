using Controllers;

class MemberController : BaseController<Member>
{
    public MemberController(ApplicationDatabaseContext appDbContect) : base(appDbContect) { }
}