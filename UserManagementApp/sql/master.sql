-- Create Users table
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

-- Insert sample data with validated passwords
INSERT INTO Users (Username, Password, Role) VALUES
('Jane', 'TeachPass1', 'Teacher'),
('Tom', 'Assist123', 'Assistant Teacher'),
('John', 'UserPass9', 'User'),
('Perera', 'Teach2025', 'Teacher'),
('Shaz', 'User123A', 'User'),
('Kamal', 'Prince77', 'Principal');
