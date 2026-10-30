using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoZar.Api.Migrations
{
    /// <inheritdoc />
    public partial class initialmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Learning");

            migrationBuilder.EnsureSchema(
                name: "Curriculum");

            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.EnsureSchema(
                name: "Content");

            migrationBuilder.EnsureSchema(
                name: "Profiles");

            migrationBuilder.CreateTable(
                name: "City",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameFa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeZoneId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentSource",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Attribution = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    License = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReviewedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LearningGoal",
                schema: "Curriculum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningGoal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDailyActivity",
                schema: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    LocalDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TimeZoneId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompletedSessions = table.Column<int>(type: "int", nullable: false),
                    ReviewedTargets = table.Column<int>(type: "int", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDailyActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDailyActivity_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPreferences",
                schema: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    DailyGoalMinutes = table.Column<int>(type: "int", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TimeZoneId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RemindersEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ReminderLocalTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPreferences_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chapter",
                schema: "Curriculum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapter_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContentPack",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StorageKey = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Sha256 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SizeBytes = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentPack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentPack_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameFa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PlaceType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Importance = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    ExternalId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Place_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Story",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageStorageKey = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Story_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransitLine",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TransportMode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ColorHex = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransitLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransitLine_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLearningProfile",
                schema: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SelectedCityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OnboardingCompletedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLearningProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLearningProfile_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserLearningProfile_City_SelectedCityId",
                        column: x => x.SelectedCityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLearningGoal",
                schema: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    LearningGoalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLearningGoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLearningGoal_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserLearningGoal_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserLearningGoal_LearningGoal_LearningGoalId",
                        column: x => x.LearningGoalId,
                        principalSchema: "Curriculum",
                        principalTable: "LearningGoal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChapterPrerequisite",
                schema: "Curriculum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequiredChapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterPrerequisite", x => x.Id);
                    table.CheckConstraint("CK_ChapterPrerequisite_NoSelf", "[ChapterId] <> [RequiredChapterId]");
                    table.ForeignKey(
                        name: "FK_ChapterPrerequisite_Chapter_ChapterId",
                        column: x => x.ChapterId,
                        principalSchema: "Curriculum",
                        principalTable: "Chapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChapterPrerequisite_Chapter_RequiredChapterId",
                        column: x => x.RequiredChapterId,
                        principalSchema: "Curriculum",
                        principalTable: "Chapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LearningSession",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SessionKind = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContentVersion = table.Column<int>(type: "int", nullable: false),
                    CompletedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LearningSession_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LearningSession_Chapter_ChapterId",
                        column: x => x.ChapterId,
                        principalSchema: "Curriculum",
                        principalTable: "Chapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LearningSession_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                schema: "Curriculum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TeachingText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_Chapter_ChapterId",
                        column: x => x.ChapterId,
                        principalSchema: "Curriculum",
                        principalTable: "Chapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContentPackAsset",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentPackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelativePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StorageKey = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Sha256 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SizeBytes = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentPackAsset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentPackAsset_ContentPack_ContentPackId",
                        column: x => x.ContentPackId,
                        principalSchema: "Content",
                        principalTable: "ContentPack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceAlias",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AliasType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceAlias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceAlias_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceFact",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceFact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceFact_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceGeometry",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeometryType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GeoJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    SourceAttribution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceGeometry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceGeometry_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceRelationship",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromPlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToPlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelationshipType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceRelationship_Place_FromPlaceId",
                        column: x => x.FromPlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlaceRelationship_Place_ToPlaceId",
                        column: x => x.ToPlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoadDetails",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoadClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsOneWay = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoadDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoadDetails_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SavedPlace",
                schema: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedPlace_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedPlace_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StationDetails",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransportMode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StationCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StationDetails_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAnchor",
                schema: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", precision: 9, scale: 6, nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnchor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnchor_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAnchor_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Catalog",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAnchor_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SavedStory",
                schema: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedStory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedStory_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedStory_Story_StoryId",
                        column: x => x.StoryId,
                        principalSchema: "Content",
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoryPlace",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoryPlace_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoryPlace_Story_StoryId",
                        column: x => x.StoryId,
                        principalSchema: "Content",
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorySource",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorySource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorySource_ContentSource_ContentSourceId",
                        column: x => x.ContentSourceId,
                        principalSchema: "Content",
                        principalTable: "ContentSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StorySource_Story_StoryId",
                        column: x => x.StoryId,
                        principalSchema: "Content",
                        principalTable: "Story",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StationLine",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationPlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransitLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StationLine_Place_StationPlaceId",
                        column: x => x.StationPlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StationLine_TransitLine_TransitLineId",
                        column: x => x.TransitLineId,
                        principalSchema: "Catalog",
                        principalTable: "TransitLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LessonPlace",
                schema: "Curriculum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonPlace_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "Curriculum",
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonPlace_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceFactSource",
                schema: "Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceFactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceFactSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceFactSource_ContentSource_ContentSourceId",
                        column: x => x.ContentSourceId,
                        principalSchema: "Content",
                        principalTable: "ContentSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlaceFactSource_PlaceFact_PlaceFactId",
                        column: x => x.PlaceFactId,
                        principalSchema: "Content",
                        principalTable: "PlaceFact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LearningTarget",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlaceRelationshipId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetKind = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningTarget", x => x.Id);
                    table.CheckConstraint("CK_LearningTarget_Reference", "([PlaceId] IS NOT NULL AND [PlaceRelationshipId] IS NULL) OR ([PlaceId] IS NULL AND [PlaceRelationshipId] IS NOT NULL)");
                    table.ForeignKey(
                        name: "FK_LearningTarget_PlaceRelationship_PlaceRelationshipId",
                        column: x => x.PlaceRelationshipId,
                        principalSchema: "Catalog",
                        principalTable: "PlaceRelationship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LearningTarget_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalSchema: "Catalog",
                        principalTable: "Place",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SessionItem",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LearningSessionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LearningTargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: false),
                    ItemKind = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IntroducedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionItem_LearningSession_LearningSessionId",
                        column: x => x.LearningSessionId,
                        principalSchema: "Learning",
                        principalTable: "LearningSession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SessionItem_LearningTarget_LearningTargetId",
                        column: x => x.LearningTargetId,
                        principalSchema: "Learning",
                        principalTable: "LearningTarget",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SessionItem_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "Curriculum",
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSkillProgress",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    LearningTargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Attempts = table.Column<int>(type: "int", nullable: false),
                    CorrectAnswers = table.Column<int>(type: "int", nullable: false),
                    LastReviewedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NextReviewAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    SchedulerStateJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkillProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkillProgress_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSkillProgress_LearningTarget_LearningTargetId",
                        column: x => x.LearningTargetId,
                        principalSchema: "Learning",
                        principalTable: "LearningTarget",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SessionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LearningTargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SkillCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Prompt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PublicContentJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswerJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_LearningTarget_LearningTargetId",
                        column: x => x.LearningTargetId,
                        principalSchema: "Learning",
                        principalTable: "LearningTarget",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercise_SessionItem_SessionItemId",
                        column: x => x.SessionItemId,
                        principalSchema: "Learning",
                        principalTable: "SessionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseOption",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseOption_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalSchema: "Learning",
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerSubmission",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientSubmissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SelectedOptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AnswerJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    ScoreAwarded = table.Column<int>(type: "int", nullable: false),
                    AnsweredAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerSubmission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerSubmission_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerSubmission_ExerciseOption_SelectedOptionId",
                        column: x => x.SelectedOptionId,
                        principalSchema: "Learning",
                        principalTable: "ExerciseOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerSubmission_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalSchema: "Learning",
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScoreTransaction",
                schema: "Learning",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    AnswerSubmissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScoreTransaction_AnswerSubmission_AnswerSubmissionId",
                        column: x => x.AnswerSubmissionId,
                        principalSchema: "Learning",
                        principalTable: "AnswerSubmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScoreTransaction_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerSubmission_ExerciseId",
                schema: "Learning",
                table: "AnswerSubmission",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerSubmission_SelectedOptionId",
                schema: "Learning",
                table: "AnswerSubmission",
                column: "SelectedOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerSubmission_UserId_ClientSubmissionId",
                schema: "Learning",
                table: "AnswerSubmission",
                columns: new[] { "UserId", "ClientSubmissionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AnswerSubmission_UserId_ExerciseId",
                schema: "Learning",
                table: "AnswerSubmission",
                columns: new[] { "UserId", "ExerciseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_CityId",
                schema: "Curriculum",
                table: "Chapter",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ChapterPrerequisite_ChapterId_RequiredChapterId",
                schema: "Curriculum",
                table: "ChapterPrerequisite",
                columns: new[] { "ChapterId", "RequiredChapterId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChapterPrerequisite_RequiredChapterId",
                schema: "Curriculum",
                table: "ChapterPrerequisite",
                column: "RequiredChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_City_Slug",
                schema: "Catalog",
                table: "City",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentPack_CityId_Version",
                schema: "Content",
                table: "ContentPack",
                columns: new[] { "CityId", "Version" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentPackAsset_ContentPackId_RelativePath",
                schema: "Content",
                table: "ContentPackAsset",
                columns: new[] { "ContentPackId", "RelativePath" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_LearningTargetId",
                schema: "Learning",
                table: "Exercise",
                column: "LearningTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_SessionItemId",
                schema: "Learning",
                table: "Exercise",
                column: "SessionItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseOption_ExerciseId_Position",
                schema: "Learning",
                table: "ExerciseOption",
                columns: new[] { "ExerciseId", "Position" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LearningGoal_Code",
                schema: "Curriculum",
                table: "LearningGoal",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LearningSession_ChapterId",
                schema: "Learning",
                table: "LearningSession",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningSession_CityId",
                schema: "Learning",
                table: "LearningSession",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningSession_UserId_ClientRequestId",
                schema: "Learning",
                table: "LearningSession",
                columns: new[] { "UserId", "ClientRequestId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LearningTarget_PlaceId",
                schema: "Learning",
                table: "LearningTarget",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LearningTarget_PlaceRelationshipId",
                schema: "Learning",
                table: "LearningTarget",
                column: "PlaceRelationshipId",
                unique: true,
                filter: "[PlaceRelationshipId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ChapterId",
                schema: "Curriculum",
                table: "Lesson",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlace_LessonId_PlaceId",
                schema: "Curriculum",
                table: "LessonPlace",
                columns: new[] { "LessonId", "PlaceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlace_PlaceId",
                schema: "Curriculum",
                table: "LessonPlace",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Place_CityId_Slug",
                schema: "Catalog",
                table: "Place",
                columns: new[] { "CityId", "Slug" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceAlias_PlaceId_LanguageCode_Name",
                schema: "Catalog",
                table: "PlaceAlias",
                columns: new[] { "PlaceId", "LanguageCode", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceFact_PlaceId",
                schema: "Content",
                table: "PlaceFact",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceFactSource_ContentSourceId",
                schema: "Content",
                table: "PlaceFactSource",
                column: "ContentSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceFactSource_PlaceFactId_ContentSourceId",
                schema: "Content",
                table: "PlaceFactSource",
                columns: new[] { "PlaceFactId", "ContentSourceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceGeometry_PlaceId_Version",
                schema: "Catalog",
                table: "PlaceGeometry",
                columns: new[] { "PlaceId", "Version" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceRelationship_FromPlaceId_ToPlaceId_RelationshipType",
                schema: "Catalog",
                table: "PlaceRelationship",
                columns: new[] { "FromPlaceId", "ToPlaceId", "RelationshipType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceRelationship_ToPlaceId",
                schema: "Catalog",
                table: "PlaceRelationship",
                column: "ToPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_RoadDetails_PlaceId",
                schema: "Catalog",
                table: "RoadDetails",
                column: "PlaceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavedPlace_PlaceId",
                schema: "Profiles",
                table: "SavedPlace",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedPlace_UserId_PlaceId",
                schema: "Profiles",
                table: "SavedPlace",
                columns: new[] { "UserId", "PlaceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavedStory_StoryId",
                schema: "Profiles",
                table: "SavedStory",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedStory_UserId_StoryId",
                schema: "Profiles",
                table: "SavedStory",
                columns: new[] { "UserId", "StoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScoreTransaction_AnswerSubmissionId",
                schema: "Learning",
                table: "ScoreTransaction",
                column: "AnswerSubmissionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScoreTransaction_UserId",
                schema: "Learning",
                table: "ScoreTransaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionItem_LearningSessionId_Position",
                schema: "Learning",
                table: "SessionItem",
                columns: new[] { "LearningSessionId", "Position" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SessionItem_LearningTargetId",
                schema: "Learning",
                table: "SessionItem",
                column: "LearningTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionItem_LessonId",
                schema: "Learning",
                table: "SessionItem",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_StationDetails_PlaceId",
                schema: "Catalog",
                table: "StationDetails",
                column: "PlaceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StationLine_StationPlaceId",
                schema: "Catalog",
                table: "StationLine",
                column: "StationPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_StationLine_TransitLineId_Position",
                schema: "Catalog",
                table: "StationLine",
                columns: new[] { "TransitLineId", "Position" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StationLine_TransitLineId_StationPlaceId",
                schema: "Catalog",
                table: "StationLine",
                columns: new[] { "TransitLineId", "StationPlaceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Story_CityId",
                schema: "Content",
                table: "Story",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryPlace_PlaceId",
                schema: "Content",
                table: "StoryPlace",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryPlace_StoryId_PlaceId",
                schema: "Content",
                table: "StoryPlace",
                columns: new[] { "StoryId", "PlaceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StorySource_ContentSourceId",
                schema: "Content",
                table: "StorySource",
                column: "ContentSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_StorySource_StoryId_ContentSourceId",
                schema: "Content",
                table: "StorySource",
                columns: new[] { "StoryId", "ContentSourceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransitLine_CityId",
                schema: "Catalog",
                table: "TransitLine",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnchor_CityId",
                schema: "Profiles",
                table: "UserAnchor",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnchor_PlaceId",
                schema: "Profiles",
                table: "UserAnchor",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnchor_UserId_CityId",
                schema: "Profiles",
                table: "UserAnchor",
                columns: new[] { "UserId", "CityId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserDailyActivity_UserId_LocalDate",
                schema: "Profiles",
                table: "UserDailyActivity",
                columns: new[] { "UserId", "LocalDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserLearningGoal_CityId",
                schema: "Profiles",
                table: "UserLearningGoal",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLearningGoal_LearningGoalId",
                schema: "Profiles",
                table: "UserLearningGoal",
                column: "LearningGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLearningGoal_UserId_CityId_LearningGoalId",
                schema: "Profiles",
                table: "UserLearningGoal",
                columns: new[] { "UserId", "CityId", "LearningGoalId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserLearningProfile_SelectedCityId",
                schema: "Profiles",
                table: "UserLearningProfile",
                column: "SelectedCityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLearningProfile_UserId",
                schema: "Profiles",
                table: "UserLearningProfile",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_UserId",
                schema: "Profiles",
                table: "UserPreferences",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSkillProgress_LearningTargetId",
                schema: "Learning",
                table: "UserSkillProgress",
                column: "LearningTargetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkillProgress_UserId_LearningTargetId_SkillCode",
                schema: "Learning",
                table: "UserSkillProgress",
                columns: new[] { "UserId", "LearningTargetId", "SkillCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSkillProgress_UserId_NextReviewAtUtc",
                schema: "Learning",
                table: "UserSkillProgress",
                columns: new[] { "UserId", "NextReviewAtUtc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChapterPrerequisite",
                schema: "Curriculum");

            migrationBuilder.DropTable(
                name: "ContentPackAsset",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "LessonPlace",
                schema: "Curriculum");

            migrationBuilder.DropTable(
                name: "PlaceAlias",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "PlaceFactSource",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "PlaceGeometry",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "RoadDetails",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "SavedPlace",
                schema: "Profiles");

            migrationBuilder.DropTable(
                name: "SavedStory",
                schema: "Profiles");

            migrationBuilder.DropTable(
                name: "ScoreTransaction",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "StationDetails",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "StationLine",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "StoryPlace",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "StorySource",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "UserAnchor",
                schema: "Profiles");

            migrationBuilder.DropTable(
                name: "UserDailyActivity",
                schema: "Profiles");

            migrationBuilder.DropTable(
                name: "UserLearningGoal",
                schema: "Profiles");

            migrationBuilder.DropTable(
                name: "UserLearningProfile",
                schema: "Profiles");

            migrationBuilder.DropTable(
                name: "UserPreferences",
                schema: "Profiles");

            migrationBuilder.DropTable(
                name: "UserSkillProgress",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "ContentPack",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "PlaceFact",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "AnswerSubmission",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "TransitLine",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ContentSource",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "Story",
                schema: "Content");

            migrationBuilder.DropTable(
                name: "LearningGoal",
                schema: "Curriculum");

            migrationBuilder.DropTable(
                name: "ExerciseOption",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "Exercise",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "SessionItem",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "LearningSession",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "LearningTarget",
                schema: "Learning");

            migrationBuilder.DropTable(
                name: "Lesson",
                schema: "Curriculum");

            migrationBuilder.DropTable(
                name: "PlaceRelationship",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Chapter",
                schema: "Curriculum");

            migrationBuilder.DropTable(
                name: "Place",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "City",
                schema: "Catalog");
        }
    }
}
