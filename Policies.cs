namespace Erpmi.Security
{
    public class Policies
    {
        ///<summary>Policy to allow viewing the current user or another user's records (Requires target userId as parameter).</summary>
        public const string ViewUserByUserId = "View User by ID";

        ///<summary>Policy to allow viewing all user records.</summary>
        public const string ViewAllUsers = "View Users";

        ///<summary>Policy to allow updating the current user or managing other user records (Requires target userId as parameter).</summary>
        public const string ManageUserByUserId = "Manage User by Id";

        ///<summary>Policy to allow adding, removing and updating other user records.</summary>
        public const string ManageAllUsers = "Manage Users";

        /// <summary>Policy to allow viewing details of the current user's role or other roles (Requires roleName as parameter).</summary>
        public const string ViewRoleByRoleName = "View Role by RoleName";

        /// <summary>Policy to allow viewing details of all roles.</summary>
        public const string ViewAllRoles = "View Roles";

        /// <summary>Policy to allow assigning roles.</summary>
        public const string AssignAllowedRoles = "Assign Roles";

        /// <summary>Policy to allow adding, removing and updating roles.</summary>
        public const string ManageAllRoles = "Manage Roles";
    }
}
