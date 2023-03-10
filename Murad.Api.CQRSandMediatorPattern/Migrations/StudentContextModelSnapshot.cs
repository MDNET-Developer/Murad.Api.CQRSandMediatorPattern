// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Murad.Api.CQRSandMediatorPattern.Data;

namespace Murad.Api.CQRSandMediatorPattern.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Murad.Api.CQRSandMediatorPattern.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            Group = "M652A2",
                            Name = "Murad",
                            Surname = "Aliyev"
                        },
                        new
                        {
                            Id = 2,
                            Age = 21,
                            Group = "N674",
                            Name = "Parviz",
                            Surname = "Yunisli"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Group = "M455",
                            Name = "Khuraman",
                            Surname = "Taghizadeh"
                        },
                        new
                        {
                            Id = 4,
                            Age = 21,
                            Group = "mM652A2",
                            Name = "Elshad",
                            Surname = "Babayev"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
