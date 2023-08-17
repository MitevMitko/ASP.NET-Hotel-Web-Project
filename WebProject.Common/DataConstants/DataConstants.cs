namespace WebProject.Common.DataConstants
{
    public static class DataConstants
    {
        public static class Room
        {
            // Name
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            // Description
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 100;

            // Price Per Night
            public const string PricePerNightMinValue = "50";
            public const string PricePerNightMaxValue = "300";
        }

        public static class Bed
        {
            // Type
            public const int TypeMinLength = 5;
            public const int TypeMaxLength = 20;
        }

        public static class AboutInfo
        {
            // Description
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 100;
        }

        public static class RoomService
        {
            // Name
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            // Description
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 100;

            // Weight
            public const decimal WeightMinValue = 300;
            public const decimal WeightMaxValue = 1000;
        }

        public static class Landmark
        {
            // Name
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            // Description
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 100;

            // Distance
            public const double DistanceMinValue = 1;
            public const double DistanceMaxValue = 50;
        }

        public static class Image
        {
            // Image
            public const int ImageMinValue = 0;
            public const int ImageMaxValue = 500000000;
        }

        public static class RoomServiceCategory
        {
            // Name
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
        }

        public static class RoomServiceSubCategory
        {
            // Name
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
        }

        public static class RoomAvailability
        {
            // Name
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
        }
        public static class RoomType
        {
            // Name
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
        }

        public static class Facilities
        {
            // Title
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 30;
        }

        public static class Activity
        {
            // Name
            public const int TitleMinLength = 4;
            public const int TitleMaxLength = 30;

            // Duration
            public const double DurationMinValue = 30;
            public const double DurationMaxValue = 120;

            // Price
            public const decimal PriceMinValue = 10;
            public const decimal PriceMaxValue = 130;
        }

        public static class User
        {
            // UserName
            public const int UserNameMinLength = 5;
            public const int UserNameMaxLength = 20;

            // Email
            public const int EmailMinLength = 10;
            public const int EmailMaxLength = 60;

            // Password
            public const int PasswordMinLength = 5;
            public const int PasswordMaxLength = 20;
        }

        public static class Admin
        {
            public const string AdminRoleName = "Administrator";
            public const string DevelopmentAdminEmail = "Mitko@abv.bg";
        }
    }
}
