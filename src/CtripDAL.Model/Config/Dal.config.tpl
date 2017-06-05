<dal name="TestPerformaceDBConfig">
	<databaseSets>
		<databaseSet name="TestPrerdb" provider="sqlProvider">
            <add name="TestPrerdb" databaseType="Master" sharding="" connectionString="TestPrerdb{$DBDataCenter}"/>   
		</databaseSet>
	</databaseSets>
	
	<databaseProviders>
        <add name="sqlProvider" type="Arch.Data.DbEngine.Providers.SqlDatabaseProvider,Arch.Data"/>
        <!--���ֻ��Sql Server,��ע�͵��������У��������������ʱ����-->
        <add name="mySqlProvider" type="Arch.Data.MySqlProvider.MySqlDatabaseProvider,Arch.Data.MySqlProvider"/>
	</databaseProviders>
</dal>