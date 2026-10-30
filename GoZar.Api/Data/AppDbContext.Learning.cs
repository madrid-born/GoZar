using Microsoft.EntityFrameworkCore;

// Keep the existing context namespace so Identity migrations retain their context identity.
namespace GoZar.Api.Models;

public partial class AppDbContext
{
    public DbSet<GoZar.Api.Domain.Geography.City> CityRecords => Set<GoZar.Api.Domain.Geography.City>();
    public DbSet<GoZar.Api.Domain.Geography.Place> PlaceRecords => Set<GoZar.Api.Domain.Geography.Place>();
    public DbSet<GoZar.Api.Domain.Geography.PlaceGeometry> PlaceGeometryRecords => Set<GoZar.Api.Domain.Geography.PlaceGeometry>();
    public DbSet<GoZar.Api.Domain.Geography.PlaceAlias> PlaceAliasRecords => Set<GoZar.Api.Domain.Geography.PlaceAlias>();
    public DbSet<GoZar.Api.Domain.Geography.PlaceRelationship> PlaceRelationshipRecords => Set<GoZar.Api.Domain.Geography.PlaceRelationship>();
    public DbSet<GoZar.Api.Domain.Geography.RoadDetails> RoadDetailsRecords => Set<GoZar.Api.Domain.Geography.RoadDetails>();
    public DbSet<GoZar.Api.Domain.Geography.StationDetails> StationDetailsRecords => Set<GoZar.Api.Domain.Geography.StationDetails>();
    public DbSet<GoZar.Api.Domain.Geography.TransitLine> TransitLineRecords => Set<GoZar.Api.Domain.Geography.TransitLine>();
    public DbSet<GoZar.Api.Domain.Geography.StationLine> StationLineRecords => Set<GoZar.Api.Domain.Geography.StationLine>();
    public DbSet<GoZar.Api.Domain.Curriculum.Chapter> ChapterRecords => Set<GoZar.Api.Domain.Curriculum.Chapter>();
    public DbSet<GoZar.Api.Domain.Curriculum.ChapterPrerequisite> ChapterPrerequisiteRecords => Set<GoZar.Api.Domain.Curriculum.ChapterPrerequisite>();
    public DbSet<GoZar.Api.Domain.Curriculum.Lesson> LessonRecords => Set<GoZar.Api.Domain.Curriculum.Lesson>();
    public DbSet<GoZar.Api.Domain.Curriculum.LessonPlace> LessonPlaceRecords => Set<GoZar.Api.Domain.Curriculum.LessonPlace>();
    public DbSet<GoZar.Api.Domain.Curriculum.LearningGoal> LearningGoalRecords => Set<GoZar.Api.Domain.Curriculum.LearningGoal>();
    public DbSet<GoZar.Api.Domain.Learning.LearningTarget> LearningTargetRecords => Set<GoZar.Api.Domain.Learning.LearningTarget>();
    public DbSet<GoZar.Api.Domain.Learning.LearningSession> LearningSessionRecords => Set<GoZar.Api.Domain.Learning.LearningSession>();
    public DbSet<GoZar.Api.Domain.Learning.SessionItem> SessionItemRecords => Set<GoZar.Api.Domain.Learning.SessionItem>();
    public DbSet<GoZar.Api.Domain.Learning.Exercise> ExerciseRecords => Set<GoZar.Api.Domain.Learning.Exercise>();
    public DbSet<GoZar.Api.Domain.Learning.ExerciseOption> ExerciseOptionRecords => Set<GoZar.Api.Domain.Learning.ExerciseOption>();
    public DbSet<GoZar.Api.Domain.Learning.AnswerSubmission> AnswerSubmissionRecords => Set<GoZar.Api.Domain.Learning.AnswerSubmission>();
    public DbSet<GoZar.Api.Domain.Learning.UserSkillProgress> UserSkillProgressRecords => Set<GoZar.Api.Domain.Learning.UserSkillProgress>();
    public DbSet<GoZar.Api.Domain.Learning.ScoreTransaction> ScoreTransactionRecords => Set<GoZar.Api.Domain.Learning.ScoreTransaction>();
    public DbSet<GoZar.Api.Domain.Users.UserLearningProfile> UserLearningProfileRecords => Set<GoZar.Api.Domain.Users.UserLearningProfile>();
    public DbSet<GoZar.Api.Domain.Users.UserLearningGoal> UserLearningGoalRecords => Set<GoZar.Api.Domain.Users.UserLearningGoal>();
    public DbSet<GoZar.Api.Domain.Users.UserAnchor> UserAnchorRecords => Set<GoZar.Api.Domain.Users.UserAnchor>();
    public DbSet<GoZar.Api.Domain.Users.UserPreferences> UserPreferencesRecords => Set<GoZar.Api.Domain.Users.UserPreferences>();
    public DbSet<GoZar.Api.Domain.Users.SavedPlace> SavedPlaceRecords => Set<GoZar.Api.Domain.Users.SavedPlace>();
    public DbSet<GoZar.Api.Domain.Users.SavedStory> SavedStoryRecords => Set<GoZar.Api.Domain.Users.SavedStory>();
    public DbSet<GoZar.Api.Domain.Users.UserDailyActivity> UserDailyActivityRecords => Set<GoZar.Api.Domain.Users.UserDailyActivity>();
    public DbSet<GoZar.Api.Domain.Content.Story> StoryRecords => Set<GoZar.Api.Domain.Content.Story>();
    public DbSet<GoZar.Api.Domain.Content.ContentSource> ContentSourceRecords => Set<GoZar.Api.Domain.Content.ContentSource>();
    public DbSet<GoZar.Api.Domain.Content.StorySource> StorySourceRecords => Set<GoZar.Api.Domain.Content.StorySource>();
    public DbSet<GoZar.Api.Domain.Content.StoryPlace> StoryPlaceRecords => Set<GoZar.Api.Domain.Content.StoryPlace>();
    public DbSet<GoZar.Api.Domain.Content.PlaceFact> PlaceFactRecords => Set<GoZar.Api.Domain.Content.PlaceFact>();
    public DbSet<GoZar.Api.Domain.Content.PlaceFactSource> PlaceFactSourceRecords => Set<GoZar.Api.Domain.Content.PlaceFactSource>();
    public DbSet<GoZar.Api.Domain.Content.ContentPack> ContentPackRecords => Set<GoZar.Api.Domain.Content.ContentPack>();
    public DbSet<GoZar.Api.Domain.Content.ContentPackAsset> ContentPackAssetRecords => Set<GoZar.Api.Domain.Content.ContentPackAsset>();
}
