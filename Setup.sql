USE timsburgers;

-- NOTE this is creating the table to put burgers in

/* -- CREATE TABLE burgers
-- (
--   id INT AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL UNIQUE,
--   description VARCHAR(255),
--   price DECIMAL(6 , 2) NOT NULL,

--   PRIMARY KEY (id)
-- ); */

-- NOTE this is creating actual burger

INSERT INTO burgers
(name, description, price, calMax, category)
VALUES
("Aloha Chris", "Mmmm", 25, 2000, "Burger")

-- Get All of a collection
-- SELECT * FROM burgers;

-- Get a specific from a collection

-- SELECT * FROM burgers WHERE description="Brisket" OR id=1;

-- DELETE FROM burgers WHERE id=1;

-- DELETE burgers;
-- TRUNCATE burgers;

-- every menu item
-- public int Id { get; set; }
-- public string Name { get; set; }
-- public decimal Price { get; set; }
-- public int CalMax { get; set; }
-- public string Category { get; set; }

-- ALTER TABLE burgers
-- ADD calMax INT,
-- ADD category VARCHAR(255);


-- CREATE TABLE drinks
-- (
--   id INT AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL UNIQUE,
--   price DECIMAL(6 , 2) NOT NULL,
--   calMax INT,
--   category VARCHAR(255),
--   size VARCHAR(255),

--   PRIMARY KEY (id)
-- ); 

-- CREATE TABLE sides
-- (
--   id INT AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL UNIQUE,
--   price DECIMAL(6 , 2) NOT NULL,
--   calMax INT,
--   category VARCHAR(255),
--   size VARCHAR(255),

--   PRIMARY KEY (id)
-- ); 


-- INSERT INTO sides
-- (name, price, calMax, category, size)
-- VALUES
-- ("Fries", 4.99, 200, "Sides", "XL");

-- INSERT INTO sides
-- (name, price, calMax, category, size)
-- VALUES
-- ("Tots", 3.99, 150, "Sides", "S")
