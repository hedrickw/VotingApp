﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "VotingApp\App.config"
//     Connection String Name: "VotingBooth"
//     Connection String:      "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VotingBox;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Express Edition (64-bit)
// Database Engine Edition: Express

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace VotingApp.DataManagement
{
    using System.Linq;

    #region Unit of work

    public interface IVotingBooth : System.IDisposable
    {
        System.Data.Entity.DbSet<Ballot> Ballots { get; set; } // Ballot
        System.Data.Entity.DbSet<Canidate> Canidates { get; set; } // Canidate
        System.Data.Entity.DbSet<Job> Jobs { get; set; } // Job
        System.Data.Entity.DbSet<Jurisdiction> Jurisdictions { get; set; } // Jurisdictions
        System.Data.Entity.DbSet<VoteResult> VoteResults { get; set; } // VoteResults

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class VotingBooth : System.Data.Entity.DbContext, IVotingBooth
    {
        public System.Data.Entity.DbSet<Ballot> Ballots { get; set; } // Ballot
        public System.Data.Entity.DbSet<Canidate> Canidates { get; set; } // Canidate
        public System.Data.Entity.DbSet<Job> Jobs { get; set; } // Job
        public System.Data.Entity.DbSet<Jurisdiction> Jurisdictions { get; set; } // Jurisdictions
        public System.Data.Entity.DbSet<VoteResult> VoteResults { get; set; } // VoteResults

        static VotingBooth()
        {
            System.Data.Entity.Database.SetInitializer<VotingBooth>(null);
        }

        public VotingBooth()
            : base("Name=VotingBooth")
        {
        }

        public VotingBooth(string connectionString)
            : base(connectionString)
        {
        }

        public VotingBooth(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public VotingBooth(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public VotingBooth(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BallotConfiguration());
            modelBuilder.Configurations.Add(new CanidateConfiguration());
            modelBuilder.Configurations.Add(new JobConfiguration());
            modelBuilder.Configurations.Add(new JurisdictionConfiguration());
            modelBuilder.Configurations.Add(new VoteResultConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new BallotConfiguration(schema));
            modelBuilder.Configurations.Add(new CanidateConfiguration(schema));
            modelBuilder.Configurations.Add(new JobConfiguration(schema));
            modelBuilder.Configurations.Add(new JurisdictionConfiguration(schema));
            modelBuilder.Configurations.Add(new VoteResultConfiguration(schema));
            return modelBuilder;
        }
    }
    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FakeVotingBooth : IVotingBooth
    {
        public System.Data.Entity.DbSet<Ballot> Ballots { get; set; }
        public System.Data.Entity.DbSet<Canidate> Canidates { get; set; }
        public System.Data.Entity.DbSet<Job> Jobs { get; set; }
        public System.Data.Entity.DbSet<Jurisdiction> Jurisdictions { get; set; }
        public System.Data.Entity.DbSet<VoteResult> VoteResults { get; set; }

        public FakeVotingBooth()
        {
            Ballots = new FakeDbSet<Ballot>("BallotId");
            Canidates = new FakeDbSet<Canidate>("CanidateId");
            Jobs = new FakeDbSet<Job>("JobId");
            Jurisdictions = new FakeDbSet<Jurisdiction>("JurisdictionId");
            VoteResults = new FakeDbSet<VoteResult>("VoteResultsId");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TElement>(expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // Ballot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Ballot
    {
        public System.Guid BallotId { get; set; } // BallotId (Primary key)
        public string BallotName { get; set; } // BallotName

        // Reverse navigation

        /// <summary>
        /// Child VoteResults where [VoteResults].[BallotId] point to this entity (FK_VoteResults_Ballot)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VoteResult> VoteResults { get; set; } // VoteResults.FK_VoteResults_Ballot

        public Ballot()
        {
            BallotId = System.Guid.NewGuid();
            VoteResults = new System.Collections.Generic.List<VoteResult>();
        }
    }

    // Canidate
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Canidate
    {
        public System.Guid CanidateId { get; set; } // CanidateId (Primary key)
        public string Name { get; set; } // Name
        public System.Guid JobId { get; set; } // JobId
        public string Party { get; set; } // Party (length: 50)
        public bool VotedFor { get; set; } // VotedFor
        public string Ranking { get; set; } // Ranking (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child VoteResults where [VoteResults].[CanindateId] point to this entity (FK_VoteResults_Canidate)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VoteResult> VoteResults { get; set; } // VoteResults.FK_VoteResults_Canidate

        // Foreign keys

        /// <summary>
        /// Parent Job pointed by [Canidate].([JobId]) (FK_Canidate_Job)
        /// </summary>
        public virtual Job Job { get; set; } // FK_Canidate_Job

        public Canidate()
        {
            CanidateId = System.Guid.NewGuid();
            VotedFor = false;
            VoteResults = new System.Collections.Generic.List<VoteResult>();
        }
    }

    // Job
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Job
    {
        public System.Guid JobId { get; set; } // JobId (Primary key)
        public System.Guid Jurisdiction { get; set; } // Jurisdiction
        public string Name { get; set; } // Name

        // Reverse navigation

        /// <summary>
        /// Child Canidates where [Canidate].[JobId] point to this entity (FK_Canidate_Job)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Canidate> Canidates { get; set; } // Canidate.FK_Canidate_Job

        // Foreign keys

        /// <summary>
        /// Parent Jurisdiction pointed by [Job].([Jurisdiction]) (FK_Job_Jurisdictions)
        /// </summary>
        public virtual Jurisdiction Jurisdiction_Jurisdiction { get; set; } // FK_Job_Jurisdictions

        public Job()
        {
            JobId = System.Guid.NewGuid();
            Canidates = new System.Collections.Generic.List<Canidate>();
        }
    }

    // Jurisdictions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Jurisdiction
    {
        public System.Guid JurisdictionId { get; set; } // JurisdictionId (Primary key)
        public string JurisdictionName { get; set; } // JurisdictionName (length: 2147483647)

        // Reverse navigation

        /// <summary>
        /// Child Jobs where [Job].[Jurisdiction] point to this entity (FK_Job_Jurisdictions)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Job> Jobs { get; set; } // Job.FK_Job_Jurisdictions

        public Jurisdiction()
        {
            Jobs = new System.Collections.Generic.List<Job>();
        }
    }

    // VoteResults
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class VoteResult
    {
        public System.Guid VoteResultsId { get; set; } // VoteResultsId (Primary key)
        public System.Guid BallotId { get; set; } // BallotId
        public System.Guid CanindateId { get; set; } // CanindateId
        public bool VotedFor { get; set; } // VotedFor
        public int? Ranking { get; set; } // Ranking

        // Foreign keys

        /// <summary>
        /// Parent Ballot pointed by [VoteResults].([BallotId]) (FK_VoteResults_Ballot)
        /// </summary>
        public virtual Ballot Ballot { get; set; } // FK_VoteResults_Ballot
        /// <summary>
        /// Parent Canidate pointed by [VoteResults].([CanindateId]) (FK_VoteResults_Canidate)
        /// </summary>
        public virtual Canidate Canidate { get; set; } // FK_VoteResults_Canidate

        public VoteResult()
        {
            VoteResultsId = System.Guid.NewGuid();
        }
    }

    #endregion

    #region POCO Configuration

    // Ballot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class BallotConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ballot>
    {
        public BallotConfiguration()
            : this("dbo")
        {
        }

        public BallotConfiguration(string schema)
        {
            ToTable("Ballot", schema);
            HasKey(x => x.BallotId);

            Property(x => x.BallotId).HasColumnName(@"BallotId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BallotName).HasColumnName(@"BallotName").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
        }
    }

    // Canidate
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class CanidateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Canidate>
    {
        public CanidateConfiguration()
            : this("dbo")
        {
        }

        public CanidateConfiguration(string schema)
        {
            ToTable("Canidate", schema);
            HasKey(x => x.CanidateId);

            Property(x => x.CanidateId).HasColumnName(@"CanidateId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.JobId).HasColumnName(@"JobId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.Party).HasColumnName(@"Party").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.VotedFor).HasColumnName(@"VotedFor").HasColumnType("bit").IsRequired();
            Property(x => x.Ranking).HasColumnName(@"Ranking").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);

            // Foreign keys
            HasRequired(a => a.Job).WithMany(b => b.Canidates).HasForeignKey(c => c.JobId).WillCascadeOnDelete(false); // FK_Canidate_Job
        }
    }

    // Job
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class JobConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
            : this("dbo")
        {
        }

        public JobConfiguration(string schema)
        {
            ToTable("Job", schema);
            HasKey(x => x.JobId);

            Property(x => x.JobId).HasColumnName(@"JobId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Jurisdiction).HasColumnName(@"Jurisdiction").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);

            // Foreign keys
            HasRequired(a => a.Jurisdiction_Jurisdiction).WithMany(b => b.Jobs).HasForeignKey(c => c.Jurisdiction).WillCascadeOnDelete(false); // FK_Job_Jurisdictions
        }
    }

    // Jurisdictions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class JurisdictionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Jurisdiction>
    {
        public JurisdictionConfiguration()
            : this("dbo")
        {
        }

        public JurisdictionConfiguration(string schema)
        {
            ToTable("Jurisdictions", schema);
            HasKey(x => x.JurisdictionId);

            Property(x => x.JurisdictionId).HasColumnName(@"JurisdictionId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.JurisdictionName).HasColumnName(@"JurisdictionName").HasColumnType("text").IsOptional().IsUnicode(false).HasMaxLength(2147483647);
        }
    }

    // VoteResults
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class VoteResultConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VoteResult>
    {
        public VoteResultConfiguration()
            : this("dbo")
        {
        }

        public VoteResultConfiguration(string schema)
        {
            ToTable("VoteResults", schema);
            HasKey(x => x.VoteResultsId);

            Property(x => x.VoteResultsId).HasColumnName(@"VoteResultsId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BallotId).HasColumnName(@"BallotId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.CanindateId).HasColumnName(@"CanindateId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.VotedFor).HasColumnName(@"VotedFor").HasColumnType("bit").IsRequired();
            Property(x => x.Ranking).HasColumnName(@"Ranking").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.Ballot).WithMany(b => b.VoteResults).HasForeignKey(c => c.BallotId).WillCascadeOnDelete(false); // FK_VoteResults_Ballot
            HasRequired(a => a.Canidate).WithMany(b => b.VoteResults).HasForeignKey(c => c.CanindateId).WillCascadeOnDelete(false); // FK_VoteResults_Canidate
        }
    }

    #endregion

}
// </auto-generated>

