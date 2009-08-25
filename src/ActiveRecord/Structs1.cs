


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace QuangPhong {
	
        /// <summary>
        /// Table: categories
        /// Primary Key: Id
        /// </summary>

        public class categoriesTable: DatabaseTable {
            
            public categoriesTable(IDataProvider provider):base("categories",provider){
                ClassName = "category";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1024
                });

                Columns.Add(new DatabaseColumn("ParentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ThumbnailImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("NormalImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("FullImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });
                    
                
                
            }
            
            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn ParentId{
                get{
                    return this.GetColumn("ParentId");
                }
            }
				
   			public static string ParentIdColumn{
			      get{
        			return "ParentId";
      			}
		    }
            
            public IColumn ThumbnailImage{
                get{
                    return this.GetColumn("ThumbnailImage");
                }
            }
				
   			public static string ThumbnailImageColumn{
			      get{
        			return "ThumbnailImage";
      			}
		    }
            
            public IColumn NormalImage{
                get{
                    return this.GetColumn("NormalImage");
                }
            }
				
   			public static string NormalImageColumn{
			      get{
        			return "NormalImage";
      			}
		    }
            
            public IColumn FullImage{
                get{
                    return this.GetColumn("FullImage");
                }
            }
				
   			public static string FullImageColumn{
			      get{
        			return "FullImage";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: products
        /// Primary Key: Id
        /// </summary>

        public class productsTable: DatabaseTable {
            
            public productsTable(IDataProvider provider):base("products",provider){
                ClassName = "product";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1024
                });

                Columns.Add(new DatabaseColumn("ThumbnailImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("NormalImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("FullImage1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("FullImage2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("FullImage3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Content", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 65535
                });

                Columns.Add(new DatabaseColumn("TechImage1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("TechImage2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("TechImage3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("CategoriesId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn ThumbnailImage{
                get{
                    return this.GetColumn("ThumbnailImage");
                }
            }
				
   			public static string ThumbnailImageColumn{
			      get{
        			return "ThumbnailImage";
      			}
		    }
            
            public IColumn NormalImage{
                get{
                    return this.GetColumn("NormalImage");
                }
            }
				
   			public static string NormalImageColumn{
			      get{
        			return "NormalImage";
      			}
		    }
            
            public IColumn FullImage1{
                get{
                    return this.GetColumn("FullImage1");
                }
            }
				
   			public static string FullImage1Column{
			      get{
        			return "FullImage1";
      			}
		    }
            
            public IColumn FullImage2{
                get{
                    return this.GetColumn("FullImage2");
                }
            }
				
   			public static string FullImage2Column{
			      get{
        			return "FullImage2";
      			}
		    }
            
            public IColumn FullImage3{
                get{
                    return this.GetColumn("FullImage3");
                }
            }
				
   			public static string FullImage3Column{
			      get{
        			return "FullImage3";
      			}
		    }
            
            public IColumn Content{
                get{
                    return this.GetColumn("Content");
                }
            }
				
   			public static string ContentColumn{
			      get{
        			return "Content";
      			}
		    }
            
            public IColumn TechImage1{
                get{
                    return this.GetColumn("TechImage1");
                }
            }
				
   			public static string TechImage1Column{
			      get{
        			return "TechImage1";
      			}
		    }
            
            public IColumn TechImage2{
                get{
                    return this.GetColumn("TechImage2");
                }
            }
				
   			public static string TechImage2Column{
			      get{
        			return "TechImage2";
      			}
		    }
            
            public IColumn TechImage3{
                get{
                    return this.GetColumn("TechImage3");
                }
            }
				
   			public static string TechImage3Column{
			      get{
        			return "TechImage3";
      			}
		    }
            
            public IColumn CategoriesId{
                get{
                    return this.GetColumn("CategoriesId");
                }
            }
				
   			public static string CategoriesIdColumn{
			      get{
        			return "CategoriesId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: users
        /// Primary Key: Id
        /// </summary>

        public class usersTable: DatabaseTable {
            
            public usersTable(IDataProvider provider):base("users",provider){
                ClassName = "user";
                SchemaName = "";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 32
                });
                    
                
                
            }
            
            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn UserName{
                get{
                    return this.GetColumn("UserName");
                }
            }
				
   			public static string UserNameColumn{
			      get{
        			return "UserName";
      			}
		    }
            
            public IColumn Password{
                get{
                    return this.GetColumn("Password");
                }
            }
				
   			public static string PasswordColumn{
			      get{
        			return "Password";
      			}
		    }
            
                    
        }
        
}