INSERT INTO Category (Title, Description, UserId) VALUES 
('Eletrônicos', 'Categoria para dispositivos eletrônicos', 'user123'),
('Livros', 'Categoria para todos os tipos de livros', 'user456'),
('Roupas', 'Categoria para vestuário', 'user789');

INSERT INTO Transaction (Title, Type, Amount, CreatedAt, PaidOrReceivedAt, UserId) VALUES 
('Compra de notebook', 1, 1500.00, '2024-07-13 10:00:00', '2024-07-14 14:30:00', 'user123'),
('Venda de livro', 2, 30.00, '2024-07-12 09:00:00', NULL, 'user456'),
('Compra de camisa', 1, 50.00, '2024-07-11 15:00:00', '2024-07-11 15:30:00', 'user789');
