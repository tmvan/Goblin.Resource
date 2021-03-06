using Goblin.Resource.Contract.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Goblin.Resource.Repository.Maps
{
    public class FileEntityMap : GoblinEntityMap<FileEntity>
    {
        public override void Map(EntityTypeBuilder<FileEntity> builder)
        {
            base.Map(builder);

            builder.ToTable(nameof(FileEntity));
            
            builder.HasIndex(x => x.Slug);

            builder.HasIndex(x => x.Hash);
        }
    }
}