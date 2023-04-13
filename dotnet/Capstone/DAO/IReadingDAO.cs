﻿using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IReadingDAO
    {
        public Reading GetReading(int readingId);
        public bool AddReading(Reading reading);
        public List<Reading> GetUserReadings(int userId);
        public List<Reading> GetUserPreviousReadings(int userId, int amount);
        public List<Reading> GetReadingsByProfile(int profileId);
        public List<BSReading> GetHistoricMeasurmentsByProfile(int profileId);
    }
}