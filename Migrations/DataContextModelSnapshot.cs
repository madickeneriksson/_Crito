﻿// <auto-generated />
using Crito.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crito.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Crito.Models.Entity.ContactFormEntity", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("Crito.Models.Entity.SubscribeFormEntity", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("Subscribes");
                });
#pragma warning restore 612, 618
        }
    }
}
