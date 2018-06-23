To support multiple languages I am using one table per language. The language table structure is similar to that of the base table. For naming convention, if the base table is Employee, then english language table will be Employee_eng, Telugu langugage table will be Employee_te and so on

EF Core requires to define one entity per each table. But in C# there will be only on table. Based on the language selected by user, I will switch the language table. In order to do this, I am creating some dummy interfaces and create multiple DB Conexts
