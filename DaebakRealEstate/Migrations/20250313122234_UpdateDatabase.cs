using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaebakRealEstate.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumPosts_ForumThreads_ForumThreadId",
                table: "ForumPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumReports_ForumPosts_ForumPostId",
                table: "ForumReports");

            migrationBuilder.DropForeignKey(
                name: "FK_PollResponses_Polls_PollId",
                table: "PollResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Polls",
                table: "Polls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Announcements",
                table: "Announcements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorPasses",
                table: "VisitorPasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRegistrations",
                table: "VehicleRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBills",
                table: "UserBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceRequests",
                table: "ServiceRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PollResponses",
                table: "PollResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumThreads",
                table: "ForumThreads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumReports",
                table: "ForumReports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumPosts",
                table: "ForumPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumCategories",
                table: "ForumCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feedbacks",
                table: "Feedbacks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacilityReservations",
                table: "FacilityReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillingItems",
                table: "BillingItems");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "USERS");

            migrationBuilder.RenameTable(
                name: "Polls",
                newName: "POLLS");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "PAYMENTS");

            migrationBuilder.RenameTable(
                name: "Facilities",
                newName: "FACILITIES");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "EVENTS");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "DOCUMENTS");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "CONTACTS");

            migrationBuilder.RenameTable(
                name: "Announcements",
                newName: "ANNOUNCEMENTS");

            migrationBuilder.RenameTable(
                name: "VisitorPasses",
                newName: "VISITOR_PASSES");

            migrationBuilder.RenameTable(
                name: "VehicleRegistrations",
                newName: "VEHICLE_REGISTRATIONS");

            migrationBuilder.RenameTable(
                name: "UserBills",
                newName: "USER_BILLS");

            migrationBuilder.RenameTable(
                name: "ServiceRequests",
                newName: "SERVICE_REQUESTS");

            migrationBuilder.RenameTable(
                name: "PollResponses",
                newName: "POLL_RESPONSES");

            migrationBuilder.RenameTable(
                name: "ForumThreads",
                newName: "FORUM_THREADS");

            migrationBuilder.RenameTable(
                name: "ForumReports",
                newName: "FORUM_REPORTS");

            migrationBuilder.RenameTable(
                name: "ForumPosts",
                newName: "FORUM_POSTS");

            migrationBuilder.RenameTable(
                name: "ForumCategories",
                newName: "FORUM_CATEGORIES");

            migrationBuilder.RenameTable(
                name: "Feedbacks",
                newName: "FEEDBACK");

            migrationBuilder.RenameTable(
                name: "FacilityReservations",
                newName: "FACILITY_RESERVATIONS");

            migrationBuilder.RenameTable(
                name: "BillingItems",
                newName: "BILLING_ITEMS");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "USERS",
                newName: "USERNAME");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "USERS",
                newName: "ROLE");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "USERS",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "USERS",
                newName: "UPDATED_AT");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "USERS",
                newName: "PROFILE_PICTURE");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "USERS",
                newName: "PHONE_NUMBER");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "USERS",
                newName: "PASSWORD_HASH");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "USERS",
                newName: "LAST_NAME");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "USERS",
                newName: "HOUSE_NUMBER");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "USERS",
                newName: "FIRST_NAME");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "USERS",
                newName: "CREATED_AT");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "USERS",
                newName: "USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Username",
                table: "USERS",
                newName: "IX_USERS_USERNAME");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "USERS",
                newName: "IX_USERS_EMAIL");

            migrationBuilder.RenameIndex(
                name: "IX_PollResponses_PollId",
                table: "POLL_RESPONSES",
                newName: "IX_POLL_RESPONSES_PollId");

            migrationBuilder.RenameIndex(
                name: "IX_ForumReports_ForumPostId",
                table: "FORUM_REPORTS",
                newName: "IX_FORUM_REPORTS_ForumPostId");

            migrationBuilder.RenameIndex(
                name: "IX_ForumPosts_ForumThreadId",
                table: "FORUM_POSTS",
                newName: "IX_FORUM_POSTS_ForumThreadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USERS",
                table: "USERS",
                column: "USER_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_POLLS",
                table: "POLLS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAYMENTS",
                table: "PAYMENTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FACILITIES",
                table: "FACILITIES",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EVENTS",
                table: "EVENTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DOCUMENTS",
                table: "DOCUMENTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CONTACTS",
                table: "CONTACTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ANNOUNCEMENTS",
                table: "ANNOUNCEMENTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VISITOR_PASSES",
                table: "VISITOR_PASSES",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VEHICLE_REGISTRATIONS",
                table: "VEHICLE_REGISTRATIONS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USER_BILLS",
                table: "USER_BILLS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SERVICE_REQUESTS",
                table: "SERVICE_REQUESTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_POLL_RESPONSES",
                table: "POLL_RESPONSES",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FORUM_THREADS",
                table: "FORUM_THREADS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FORUM_REPORTS",
                table: "FORUM_REPORTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FORUM_POSTS",
                table: "FORUM_POSTS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FORUM_CATEGORIES",
                table: "FORUM_CATEGORIES",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FEEDBACK",
                table: "FEEDBACK",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FACILITY_RESERVATIONS",
                table: "FACILITY_RESERVATIONS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BILLING_ITEMS",
                table: "BILLING_ITEMS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_POSTS_FORUM_THREADS_ForumThreadId",
                table: "FORUM_POSTS",
                column: "ForumThreadId",
                principalTable: "FORUM_THREADS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FORUM_REPORTS_FORUM_POSTS_ForumPostId",
                table: "FORUM_REPORTS",
                column: "ForumPostId",
                principalTable: "FORUM_POSTS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_POLL_RESPONSES_POLLS_PollId",
                table: "POLL_RESPONSES",
                column: "PollId",
                principalTable: "POLLS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_POSTS_FORUM_THREADS_ForumThreadId",
                table: "FORUM_POSTS");

            migrationBuilder.DropForeignKey(
                name: "FK_FORUM_REPORTS_FORUM_POSTS_ForumPostId",
                table: "FORUM_REPORTS");

            migrationBuilder.DropForeignKey(
                name: "FK_POLL_RESPONSES_POLLS_PollId",
                table: "POLL_RESPONSES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USERS",
                table: "USERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_POLLS",
                table: "POLLS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PAYMENTS",
                table: "PAYMENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FACILITIES",
                table: "FACILITIES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EVENTS",
                table: "EVENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DOCUMENTS",
                table: "DOCUMENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CONTACTS",
                table: "CONTACTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ANNOUNCEMENTS",
                table: "ANNOUNCEMENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VISITOR_PASSES",
                table: "VISITOR_PASSES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VEHICLE_REGISTRATIONS",
                table: "VEHICLE_REGISTRATIONS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USER_BILLS",
                table: "USER_BILLS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SERVICE_REQUESTS",
                table: "SERVICE_REQUESTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_POLL_RESPONSES",
                table: "POLL_RESPONSES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FORUM_THREADS",
                table: "FORUM_THREADS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FORUM_REPORTS",
                table: "FORUM_REPORTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FORUM_POSTS",
                table: "FORUM_POSTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FORUM_CATEGORIES",
                table: "FORUM_CATEGORIES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FEEDBACK",
                table: "FEEDBACK");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FACILITY_RESERVATIONS",
                table: "FACILITY_RESERVATIONS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BILLING_ITEMS",
                table: "BILLING_ITEMS");

            migrationBuilder.RenameTable(
                name: "USERS",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "POLLS",
                newName: "Polls");

            migrationBuilder.RenameTable(
                name: "PAYMENTS",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "FACILITIES",
                newName: "Facilities");

            migrationBuilder.RenameTable(
                name: "EVENTS",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "DOCUMENTS",
                newName: "Documents");

            migrationBuilder.RenameTable(
                name: "CONTACTS",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "ANNOUNCEMENTS",
                newName: "Announcements");

            migrationBuilder.RenameTable(
                name: "VISITOR_PASSES",
                newName: "VisitorPasses");

            migrationBuilder.RenameTable(
                name: "VEHICLE_REGISTRATIONS",
                newName: "VehicleRegistrations");

            migrationBuilder.RenameTable(
                name: "USER_BILLS",
                newName: "UserBills");

            migrationBuilder.RenameTable(
                name: "SERVICE_REQUESTS",
                newName: "ServiceRequests");

            migrationBuilder.RenameTable(
                name: "POLL_RESPONSES",
                newName: "PollResponses");

            migrationBuilder.RenameTable(
                name: "FORUM_THREADS",
                newName: "ForumThreads");

            migrationBuilder.RenameTable(
                name: "FORUM_REPORTS",
                newName: "ForumReports");

            migrationBuilder.RenameTable(
                name: "FORUM_POSTS",
                newName: "ForumPosts");

            migrationBuilder.RenameTable(
                name: "FORUM_CATEGORIES",
                newName: "ForumCategories");

            migrationBuilder.RenameTable(
                name: "FEEDBACK",
                newName: "Feedbacks");

            migrationBuilder.RenameTable(
                name: "FACILITY_RESERVATIONS",
                newName: "FacilityReservations");

            migrationBuilder.RenameTable(
                name: "BILLING_ITEMS",
                newName: "BillingItems");

            migrationBuilder.RenameColumn(
                name: "USERNAME",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "ROLE",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UPDATED_AT",
                table: "Users",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "PROFILE_PICTURE",
                table: "Users",
                newName: "ProfilePicture");

            migrationBuilder.RenameColumn(
                name: "PHONE_NUMBER",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "PASSWORD_HASH",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "LAST_NAME",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "HOUSE_NUMBER",
                table: "Users",
                newName: "HouseNumber");

            migrationBuilder.RenameColumn(
                name: "FIRST_NAME",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "CREATED_AT",
                table: "Users",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "USER_ID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_USERS_USERNAME",
                table: "Users",
                newName: "IX_Users_Username");

            migrationBuilder.RenameIndex(
                name: "IX_USERS_EMAIL",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_POLL_RESPONSES_PollId",
                table: "PollResponses",
                newName: "IX_PollResponses_PollId");

            migrationBuilder.RenameIndex(
                name: "IX_FORUM_REPORTS_ForumPostId",
                table: "ForumReports",
                newName: "IX_ForumReports_ForumPostId");

            migrationBuilder.RenameIndex(
                name: "IX_FORUM_POSTS_ForumThreadId",
                table: "ForumPosts",
                newName: "IX_ForumPosts_ForumThreadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Polls",
                table: "Polls",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Announcements",
                table: "Announcements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorPasses",
                table: "VisitorPasses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleRegistrations",
                table: "VehicleRegistrations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBills",
                table: "UserBills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceRequests",
                table: "ServiceRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PollResponses",
                table: "PollResponses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumThreads",
                table: "ForumThreads",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumReports",
                table: "ForumReports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumPosts",
                table: "ForumPosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumCategories",
                table: "ForumCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feedbacks",
                table: "Feedbacks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacilityReservations",
                table: "FacilityReservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillingItems",
                table: "BillingItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumPosts_ForumThreads_ForumThreadId",
                table: "ForumPosts",
                column: "ForumThreadId",
                principalTable: "ForumThreads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumReports_ForumPosts_ForumPostId",
                table: "ForumReports",
                column: "ForumPostId",
                principalTable: "ForumPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PollResponses_Polls_PollId",
                table: "PollResponses",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
