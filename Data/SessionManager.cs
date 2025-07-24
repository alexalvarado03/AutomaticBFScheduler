using BFConfigApp;

namespace BFConfigApp.Data
{
    public static class SessionManager
    {
        public static UserSession CurrentSession { get; set; } = new();

        public static CaseBuildingUserSession CurrentCaseSession { get; set; } = new();
    }
}
