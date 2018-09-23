using System;
using System.Collections.Generic;
using System.Text;

namespace Starter.Core.Data.Database
{
    public class StarterDB
    {
        private Settings _settings;

        public StarterDB(Settings settings)
        {
            _settings = settings;
        }

        public StarterDBConnection GetConnection()
        {
            return new StarterDBConnection(_settings.ConnectionString)
            {
                CommandTimeout = 60
            };
        }
    }
}
