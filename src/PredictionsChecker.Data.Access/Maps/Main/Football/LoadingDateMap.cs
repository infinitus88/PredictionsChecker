using Microsoft.EntityFrameworkCore;
using PredictionsChecker.Data.Access.Maps.Common;
using PredictionsChecker.Data.Models.Football;
using System;
using System.Collections.Generic;
using System.Text;

namespace PredictionsChecker.Data.Access.Maps.Main.Football
{
    public class LoadingDateMap : IMap
    {
        public void Visit(ModelBuilder builder)
        {
            builder.Entity<LoadingDate>()
                .ToTable("LoadingDates")
                .HasKey(x => x.Id);
        }
    }

    public class PredictionRecordMap : IMap
    {
        public void Visit(ModelBuilder builder)
        {
            builder.Entity<PredictionRecord>()
                .ToTable("PredictionRecords")
                .HasKey(x => x.Id);
        }
    }
}
