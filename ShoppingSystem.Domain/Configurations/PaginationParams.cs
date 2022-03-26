﻿namespace ShoppingSystem.Domain.Configurations
{
    public class PaginationParams
    {
        private int maxPageSize = 20;

        private int pageSize;
        public int PageSize { get => pageSize; set => pageSize = value > maxPageSize ? maxPageSize : value; }

        public int PageIndex { get; set; }
    }
}