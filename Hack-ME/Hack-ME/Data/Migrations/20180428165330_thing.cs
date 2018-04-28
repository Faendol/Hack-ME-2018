using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Hack_ME.Data.Migrations
{
    public partial class thing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Location_LocationID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Group_GroupID",
                table: "StudentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Student_StudentID",
                table: "StudentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroup_Group_GroupID",
                table: "TeacherGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGroup_Teacher_TeacherID",
                table: "TeacherGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherGroup",
                table: "TeacherGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentGroup",
                table: "StudentGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "TeacherGroup",
                newName: "teacherGroups");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "_teachers");

            migrationBuilder.RenameTable(
                name: "StudentGroup",
                newName: "studentGroups");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "_students");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "_locations");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "_groups");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherGroup_GroupID",
                table: "teacherGroups",
                newName: "IX_teacherGroups_GroupID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentGroup_GroupID",
                table: "studentGroups",
                newName: "IX_studentGroups_GroupID");

            migrationBuilder.RenameIndex(
                name: "IX_Student_LocationID",
                table: "_students",
                newName: "IX__students_LocationID");

            migrationBuilder.AddColumn<int>(
                name: "studentID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "teacherID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_teacherGroups",
                table: "teacherGroups",
                columns: new[] { "TeacherID", "GroupID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__teachers",
                table: "_teachers",
                column: "TeacherID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentGroups",
                table: "studentGroups",
                columns: new[] { "StudentID", "GroupID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__students",
                table: "_students",
                column: "StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__locations",
                table: "_locations",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__groups",
                table: "_groups",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK__students__locations_LocationID",
                table: "_students",
                column: "LocationID",
                principalTable: "_locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_studentGroups__groups_GroupID",
                table: "studentGroups",
                column: "GroupID",
                principalTable: "_groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentGroups__students_StudentID",
                table: "studentGroups",
                column: "StudentID",
                principalTable: "_students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teacherGroups__groups_GroupID",
                table: "teacherGroups",
                column: "GroupID",
                principalTable: "_groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teacherGroups__teachers_TeacherID",
                table: "teacherGroups",
                column: "TeacherID",
                principalTable: "_teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__students__locations_LocationID",
                table: "_students");

            migrationBuilder.DropForeignKey(
                name: "FK_studentGroups__groups_GroupID",
                table: "studentGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_studentGroups__students_StudentID",
                table: "studentGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_teacherGroups__groups_GroupID",
                table: "teacherGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_teacherGroups__teachers_TeacherID",
                table: "teacherGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teacherGroups",
                table: "teacherGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentGroups",
                table: "studentGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK__teachers",
                table: "_teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK__students",
                table: "_students");

            migrationBuilder.DropPrimaryKey(
                name: "PK__locations",
                table: "_locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK__groups",
                table: "_groups");

            migrationBuilder.DropColumn(
                name: "studentID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "teacherID",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "teacherGroups",
                newName: "TeacherGroup");

            migrationBuilder.RenameTable(
                name: "studentGroups",
                newName: "StudentGroup");

            migrationBuilder.RenameTable(
                name: "_teachers",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "_students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "_locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "_groups",
                newName: "Group");

            migrationBuilder.RenameIndex(
                name: "IX_teacherGroups_GroupID",
                table: "TeacherGroup",
                newName: "IX_TeacherGroup_GroupID");

            migrationBuilder.RenameIndex(
                name: "IX_studentGroups_GroupID",
                table: "StudentGroup",
                newName: "IX_StudentGroup_GroupID");

            migrationBuilder.RenameIndex(
                name: "IX__students_LocationID",
                table: "Student",
                newName: "IX_Student_LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherGroup",
                table: "TeacherGroup",
                columns: new[] { "TeacherID", "GroupID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentGroup",
                table: "StudentGroup",
                columns: new[] { "StudentID", "GroupID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "TeacherID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Location_LocationID",
                table: "Student",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Group_GroupID",
                table: "StudentGroup",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Student_StudentID",
                table: "StudentGroup",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroup_Group_GroupID",
                table: "TeacherGroup",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGroup_Teacher_TeacherID",
                table: "TeacherGroup",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
