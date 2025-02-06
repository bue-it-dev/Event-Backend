using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Event.EventModel;

public partial class EventContext : DbContext
{
    public EventContext()
    {
    }

    public EventContext(DbContextOptions<EventContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accommodation> Accommodations { get; set; }

    public virtual DbSet<ApprovalSchema> ApprovalSchemas { get; set; }

    public virtual DbSet<BuildingLookup> BuildingLookups { get; set; }

    public virtual DbSet<BuildingVenue> BuildingVenues { get; set; }

    public virtual DbSet<DepartmentTypeLookup> DepartmentTypeLookups { get; set; }

    public virtual DbSet<EventApproval> EventApprovals { get; set; }

    public virtual DbSet<EventApprovalLevelLookup> EventApprovalLevelLookups { get; set; }

    public virtual DbSet<EventEntity> EventEntities { get; set; }

    public virtual DbSet<ItcomponentEvent> ItcomponentEvents { get; set; }

    public virtual DbSet<ItcomponentLookup> ItcomponentLookups { get; set; }

    public virtual DbSet<NatureOfEventLookup> NatureOfEventLookups { get; set; }

    public virtual DbSet<RoomLookup> RoomLookups { get; set; }

    public virtual DbSet<Transportation> Transportations { get; set; }

    public virtual DbSet<TransportationType> TransportationTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserTypeLookup> UserTypeLookups { get; set; }

    public virtual DbSet<VenueLookup> VenueLookups { get; set; }

    public virtual DbSet<VenueTypeLookup> VenueTypeLookups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=E-SARA-ELSHRIFE\\MSSQLSERVER01;Database=Event;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accommodation>(entity =>
        {
            entity.HasKey(e => e.AccommodationId).HasName("PK__Accommod__20C0A5FD7789999D");

            entity.ToTable("Accommodation");

            entity.Property(e => e.AccommodationId).HasColumnName("accommodationId");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");

            entity.HasOne(d => d.Event).WithMany(p => p.Accommodations)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Accommoda__event__5812160E");

            entity.HasOne(d => d.RoomType).WithMany(p => p.Accommodations)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK__Accommoda__roomT__59063A47");
        });

        modelBuilder.Entity<ApprovalSchema>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("ApprovalSchema");

            entity.Property(e => e.RowId).HasColumnName("rowId");
            entity.Property(e => e.DepName).HasColumnName("depName");
            entity.Property(e => e.DepTypeId).HasColumnName("depTypeId");
            entity.Property(e => e.FirstApprovalLevelId).HasColumnName("firstApprovalLevelID");
            entity.Property(e => e.SecondApprovalLevelId).HasColumnName("secondApprovalLevelID");
        });

        modelBuilder.Entity<BuildingLookup>(entity =>
        {
            entity.HasKey(e => e.BuildingId).HasName("PK__Building__979FD1CDCD815922");

            entity.ToTable("BuildingLookup");

            entity.Property(e => e.BuildingId).HasColumnName("buildingId");
            entity.Property(e => e.Building)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("building");
        });

        modelBuilder.Entity<BuildingVenue>(entity =>
        {
            entity.HasKey(e => e.VenueBuildingId).HasName("PK__Building__B0A1D97F646DF051");

            entity.ToTable("BuildingVenue");

            entity.Property(e => e.VenueBuildingId).HasColumnName("venueBuildingId");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.VenueId).HasColumnName("venueId");

            entity.HasOne(d => d.Event).WithMany(p => p.BuildingVenues)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__BuildingV__event__59FA5E80");

            entity.HasOne(d => d.Venue).WithMany(p => p.BuildingVenues)
                .HasForeignKey(d => d.VenueId)
                .HasConstraintName("FK__BuildingV__venue__5AEE82B9");
        });

        modelBuilder.Entity<DepartmentTypeLookup>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("DepartmentType_Lookup");

            entity.Property(e => e.RowId).HasColumnName("rowId");
            entity.Property(e => e.DepTypeName).HasColumnName("depTypeName");
        });

        modelBuilder.Entity<EventApproval>(entity =>
        {
            entity.HasKey(e => e.ApprovalId).HasName("PK_BusinessApprovals");

            entity.Property(e => e.ApprovalId).HasColumnName("approvalID");
            entity.Property(e => e.ApprovalLevelId).HasColumnName("approvalLevelID");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.EmpId).HasColumnName("empID");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.ApprovalLevel).WithMany(p => p.EventApprovals)
                .HasForeignKey(d => d.ApprovalLevelId)
                .HasConstraintName("FK_EventApprovals_EventApprovalLevelLookup");

            entity.HasOne(d => d.Event).WithMany(p => p.EventApprovals)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BusinessApprovals_BusinessRequest");
        });

        modelBuilder.Entity<EventApprovalLevelLookup>(entity =>
        {
            entity.HasKey(e => e.EventApprovalLevelId).HasName("PK_BusinessApprovalLevelLookup");

            entity.ToTable("EventApprovalLevelLookup");

            entity.Property(e => e.EventApprovalLevelId).HasColumnName("eventApprovalLevelId");
            entity.Property(e => e.ApprovalLevel).HasColumnName("approvalLevel");
            entity.Property(e => e.ApprovalLevelName)
                .HasMaxLength(50)
                .HasColumnName("approvalLevelName");
        });

        modelBuilder.Entity<EventEntity>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK_BusinessRequest");

            entity.ToTable("EventEntity");

            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.ApprovingDepTypeId).HasColumnName("approvingDepTypeID");
            entity.Property(e => e.ApprovingDeptName)
                .HasMaxLength(50)
                .HasColumnName("approvingDeptName");
            entity.Property(e => e.BudgetCode).HasColumnName("budgetCode");
            entity.Property(e => e.BudgetCostCenter).HasColumnName("budgetCostCenter");
            entity.Property(e => e.BudgetlineName).HasColumnName("budgetlineName");
            entity.Property(e => e.BudgetlineType).HasColumnName("budgetlineType");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventEndDate)
                .HasColumnType("datetime")
                .HasColumnName("eventEndDate");
            entity.Property(e => e.EventStartDate)
                .HasColumnType("datetime")
                .HasColumnName("eventStartDate");
            entity.Property(e => e.HasAccomdation).HasColumnName("hasAccomdation");
            entity.Property(e => e.HasIt).HasColumnName("hasIT");
            entity.Property(e => e.HasTransportation).HasColumnName("hasTransportation");
            entity.Property(e => e.IsAcademic).HasColumnName("isAcademic");
            entity.Property(e => e.OrganizerExtention).HasColumnName("organizerExtention");
            entity.Property(e => e.OrganizerMobile).HasColumnName("organizerMobile");
            entity.Property(e => e.OrganizerName)
                .HasMaxLength(50)
                .HasColumnName("organizerName");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.UpdateAt)
                .HasColumnType("datetime")
                .HasColumnName("update_at");
        });

        modelBuilder.Entity<ItcomponentEvent>(entity =>
        {
            entity.HasKey(e => e.ItcomponentEventId).HasName("PK__ITCompon__0760172737F25CC7");

            entity.ToTable("ITComponentEvent");

            entity.Property(e => e.ItcomponentEventId).HasColumnName("ITComponentEventId");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.ItcomponentId).HasColumnName("ITComponentId");

            entity.HasOne(d => d.Event).WithMany(p => p.ItcomponentEvents)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__ITCompone__event__5DCAEF64");
        });

        modelBuilder.Entity<ItcomponentLookup>(entity =>
        {
            entity.HasKey(e => e.ItcomponentId).HasName("PK__ITCompon__2E8098FCD990C7BA");

            entity.ToTable("ITComponentLookup");

            entity.Property(e => e.ItcomponentId).HasColumnName("ITComponentId");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("component");
        });

        modelBuilder.Entity<NatureOfEventLookup>(entity =>
        {
            entity.HasKey(e => e.NatureOfEventId).HasName("PK__NatureOf__0D27B156BDB43A23");

            entity.ToTable("NatureOfEventLookup");

            entity.Property(e => e.NatureOfEventId).HasColumnName("natureOfEventId");
            entity.Property(e => e.NatureOfEvent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("natureOfEvent");
        });

        modelBuilder.Entity<RoomLookup>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__roomLook__5E5E0CF3045C69D6");

            entity.ToTable("roomLookup");

            entity.Property(e => e.RoomTypeId).HasColumnName("roomTypeId");
            entity.Property(e => e.RoomType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("roomType");
        });

        modelBuilder.Entity<Transportation>(entity =>
        {
            entity.HasKey(e => e.TransportationId).HasName("PK__Transpor__B8DDDFADDBE5FCA7");

            entity.ToTable("Transportation");

            entity.Property(e => e.TransportationId).HasColumnName("transportationId");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.TransportationTypeId).HasColumnName("transportationTypeId");

            entity.HasOne(d => d.Event).WithMany(p => p.Transportations)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Transport__event__5FB337D6");

            entity.HasOne(d => d.TransportationType).WithMany(p => p.Transportations)
                .HasForeignKey(d => d.TransportationTypeId)
                .HasConstraintName("FK__Transport__trans__60A75C0F");
        });

        modelBuilder.Entity<TransportationType>(entity =>
        {
            entity.HasKey(e => e.TransportationTypeId).HasName("PK__Transpor__FA9B322B3D73C5B7");

            entity.ToTable("TransportationType");

            entity.Property(e => e.TransportationTypeId).HasColumnName("transportationTypeId");
            entity.Property(e => e.TransportationType1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("transportationType");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasColumnName("createdBy");
            entity.Property(e => e.DepId).HasColumnName("DepID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.EmpId).HasColumnName("empID");
            entity.Property(e => e.IsAcadmic).HasColumnName("isAcadmic");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");
            entity.Property(e => e.UserTypeId).HasColumnName("userTypeID");
        });

        modelBuilder.Entity<UserTypeLookup>(entity =>
        {
            entity.HasKey(e => e.RowId).HasName("PK_userTypeLooku[");

            entity.ToTable("userTypeLookup");

            entity.Property(e => e.RowId).HasColumnName("rowId");
            entity.Property(e => e.UserTypeId).HasColumnName("userTypeID");
            entity.Property(e => e.UserTypeName)
                .HasMaxLength(50)
                .HasColumnName("userTypeName");
        });

        modelBuilder.Entity<VenueLookup>(entity =>
        {
            entity.HasKey(e => e.VenueId).HasName("PK__venueLoo__4DDFB6FF97A86DD7");

            entity.ToTable("venueLookup");

            entity.Property(e => e.VenueId).HasColumnName("venueId");
            entity.Property(e => e.BuildingId).HasColumnName("buildingID");
            entity.Property(e => e.VenueTypeId).HasColumnName("venueTypeID");

            entity.HasOne(d => d.Building).WithMany(p => p.VenueLookups)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK__venueLook__build__619B8048");

            entity.HasOne(d => d.VenueType).WithMany(p => p.VenueLookups)
                .HasForeignKey(d => d.VenueTypeId)
                .HasConstraintName("FK__venueLook__venue__628FA481");
        });

        modelBuilder.Entity<VenueTypeLookup>(entity =>
        {
            entity.HasKey(e => e.VenueTypeId).HasName("PK__venueTyp__F705DB0E8B450C4B");

            entity.ToTable("venueTypeLookup");

            entity.Property(e => e.VenueTypeId).HasColumnName("venueTypeID");
            entity.Property(e => e.Venue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("venue");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
