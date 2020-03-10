using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs"); //Khi tạo trong database sẽ có thêm s phía sau
            builder.HasKey(x => x.Key); //Tạo khóa chính
            builder.Property(x => x.Value).IsRequired(true); //Không được bỏ trống
        }
    }
}
