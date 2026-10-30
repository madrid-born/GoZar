using GoZar.Api.Domain.Content;
using GoZar.Api.Domain.Curriculum;
using GoZar.Api.Domain.Geography;
using GoZar.Api.Domain.Learning;
using GoZar.Api.Domain.Users;
using Microsoft.EntityFrameworkCore;

// Keep the existing context namespace so Identity migrations retain their context identity.
namespace GoZar.Api.Models;

public partial class AppDbContext
{
    public DbSet<City> CityRecords => Set<City>();
    public DbSet<Place> PlaceRecords => Set<Place>();
    public DbSet<PlaceGeometry> PlaceGeometryRecords => Set<PlaceGeometry>();
    public DbSet<PlaceAlias> PlaceAliasRecords => Set<PlaceAlias>();
    public DbSet<PlaceRelationship> PlaceRelationshipRecords => Set<PlaceRelationship>();
    public DbSet<RoadDetails> RoadDetailsRecords => Set<RoadDetails>();
    public DbSet<StationDetails> StationDetailsRecords => Set<StationDetails>();
    public DbSet<TransitLine> TransitLineRecords => Set<TransitLine>();
    public DbSet<StationLine> StationLineRecords => Set<StationLine>();
    public DbSet<Chapter> ChapterRecords => Set<Chapter>();
    public DbSet<ChapterPrerequisite> ChapterPrerequisiteRecords => Set<ChapterPrerequisite>();
    public DbSet<Lesson> LessonRecords => Set<Lesson>();
    public DbSet<LessonPlace> LessonPlaceRecords => Set<LessonPlace>();
    public DbSet<LearningGoal> LearningGoalRecords => Set<LearningGoal>();
    public DbSet<LearningTarget> LearningTargetRecords => Set<LearningTarget>();
    public DbSet<LearningSession> LearningSessionRecords => Set<LearningSession>();
    public DbSet<SessionItem> SessionItemRecords => Set<SessionItem>();
    public DbSet<Exercise> ExerciseRecords => Set<Exercise>();
    public DbSet<ExerciseOption> ExerciseOptionRecords => Set<ExerciseOption>();
    public DbSet<AnswerSubmission> AnswerSubmissionRecords => Set<AnswerSubmission>();
    public DbSet<UserSkillProgress> UserSkillProgressRecords => Set<UserSkillProgress>();
    public DbSet<ScoreTransaction> ScoreTransactionRecords => Set<ScoreTransaction>();
    public DbSet<UserLearningProfile> UserLearningProfileRecords => Set<UserLearningProfile>();
    public DbSet<UserLearningGoal> UserLearningGoalRecords => Set<UserLearningGoal>();
    public DbSet<UserAnchor> UserAnchorRecords => Set<UserAnchor>();
    public DbSet<UserPreferences> UserPreferencesRecords => Set<UserPreferences>();
    public DbSet<SavedPlace> SavedPlaceRecords => Set<SavedPlace>();
    public DbSet<SavedStory> SavedStoryRecords => Set<SavedStory>();
    public DbSet<UserDailyActivity> UserDailyActivityRecords => Set<UserDailyActivity>();
    public DbSet<Story> StoryRecords => Set<Story>();
    public DbSet<ContentSource> ContentSourceRecords => Set<ContentSource>();
    public DbSet<StorySource> StorySourceRecords => Set<StorySource>();
    public DbSet<StoryPlace> StoryPlaceRecords => Set<StoryPlace>();
    public DbSet<PlaceFact> PlaceFactRecords => Set<PlaceFact>();
    public DbSet<PlaceFactSource> PlaceFactSourceRecords => Set<PlaceFactSource>();
    public DbSet<ContentPack> ContentPackRecords => Set<ContentPack>();
    public DbSet<ContentPackAsset> ContentPackAssetRecords => Set<ContentPackAsset>();
}
