using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class RoomTypeConfig : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.ToTable("RoomTypes");

            builder.HasKey(rt => rt.Id);
            
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(max)");
            builder.Property(x => x.Price).HasPrecision(9, 2);
        }
    }
}