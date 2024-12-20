# Sistema de Gerenciamento de Estoque para Comércio Eletrônico

## Descrição

Este repositório contém o código de um **Sistema de Gerenciamento de Estoque** desenvolvido para uma empresa de comércio eletrônico. O sistema tem como objetivo otimizar as operações de estoque, melhorando a eficiência e precisão na gestão de produtos, com foco em funcionalidades como cadastro, movimentação e rastreamento de produtos, além de geração de relatórios detalhados.

## Funcionalidades

- **Cadastro de Produtos**: Permite o cadastro de novos produtos no sistema com informações como:
  - Nome
  - Categoria
  - Quantidade em estoque
  - Preço
  - Localização no depósito

- **Atualização de Estoque**: Atualiza a quantidade de produtos em estoque sempre que novos itens são recebidos ou quando produtos são vendidos.

- **Rastreamento de Localização**: Facilita o rastreamento da localização dos produtos dentro dos depósitos para otimizar a logística.

- **Relatórios**: Geração de relatórios detalhados sobre:
  - Produtos com estoque baixo
  - Excesso de estoque
  - Movimentação de produtos no sistema

## Estruturas de Dados

- **Produto**: Estrutura para armazenar informações de cada item em estoque.
- **Categoria**: Para organizar os produtos por categoria.
- **Movimentação de Estoque**: Estrutura para registrar a entrada e saída de produtos.

## Algoritmos Implementados

- **Cadastro de Produtos**: Função para adicionar novos produtos ao estoque.
- **Consulta de Produtos**: Função para consultar os detalhes dos produtos cadastrados.
- **Movimentação de Estoque**: Função para registrar as movimentações de estoque, seja entrada (compra) ou saída (venda).
- **Relatórios**: Função para gerar relatórios sobre o estado atual do estoque, produtos com falta ou excesso, e movimentações realizadas.
