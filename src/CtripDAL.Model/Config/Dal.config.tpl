<dal name="TestPerformaceDBConfig">
	<databaseSets>
		<databaseSet name="TestPrerdb" provider="sqlProvider">
            <add name="TestPrerdb" databaseType="Master" sharding="" connectionString="TestPrerdb{$DBDataCenter}"/>   
		</databaseSet>
	</databaseSets>
	
	<databaseProviders>
        <add name="sqlProvider" type="Arch.Data.DbEngine.Providers.SqlDatabaseProvider,Arch.Data"/>
        <!--如果只用Sql Server,请注释掉下面这行，否则可能有运行时错误-->
        <add name="mySqlProvider" type="Arch.Data.MySqlProvider.MySqlDatabaseProvider,Arch.Data.MySqlProvider"/>
	</databaseProviders>
</dal>