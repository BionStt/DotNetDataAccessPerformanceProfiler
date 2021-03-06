DotNet DataAccess Component Performance Profiler 
=============
## Target components

*   NHibernate v1.02

*   Enterprise Library Data Access Application Block 6

*   Simple.Data

*   Dapper

*   SubSonic 3.0

*   Entity Framework

*   LinqToSQL

*   Telerik Open Access

*   Linq2db 1.8

*   PetaPoco  5.1

*   [Ctrip DAL C# client](https://github.com/ctripcorp/dal/wiki/C%23%E5%AE%A2%E6%88%B7%E7%AB%AF-%E9%9B%86%E6%88%90%E8%AF%B4%E6%98%8E)

## Dependency

*   .Net Framework 4.5
*   Unity 3.0
*   CommonServiceLocator 1.3
*   SQL SERVER 2012 R2 or later

## How to add new DAL provider?
1.Create new library project and add new class inherit from IPerformanceTest.
  Added CRUD logic with database.

2.Set build output path as Parent Project output: 
```
..\bin\Debug\
```

3. Added specifc register type for Unity config files.  

4. Rebuild whole solution and run Main App.

## RoadMap
1. Prepare integrated with BenchmarkDotNet and DashBoard


## Thoughts
Most of those ORM/DataAccess frameworks have lots of features and requires lots of knowledge. Some seem very easy at the beginning but there are many things you shall care about:

*   Caching
*   Many-to-many relationships
*   Lazy loading
*   Inheritance
*   Composite keys
*   How to encapsulate infratructure from callers
*   How SQL statements are generated
*   How to make advanced database queries

## License
Copyright (c) 2007-2017 Megadotnet Contributors

Other software included in this distribution is owned and
licensed separately, see the included license files for details.

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
