using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class DbMigrator
    {
        //introduces and initializes the field Logger
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            //initializes logger in the constructor
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("migrating...");
        }
    }
}