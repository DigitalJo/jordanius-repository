using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace GeneratedCode
{
    public class GeneratedClass
    {
        // Creates a SpreadsheetDocument.
        public void CreatePackage(string filePath)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                CreateParts(package);
            }
        }

        private void CreateParts(SpreadsheetDocument document)
        {
            WorkbookPart workbookPart1 = document.AddWorkbookPart();
            GenerateWorkbookPart1Content(workbookPart1);

            // Create sharedstring
            SharedStringTablePart sharedStringTablePart1 = workbookPart1.AddNewPart<SharedStringTablePart>("rId7");
            GenerateSharedStringTablePart1Content(sharedStringTablePart1);

            // Create Sheet2
            WorksheetPart worksheetPart2 = workbookPart1.AddNewPart<WorksheetPart>("rId2");
            GenerateWorksheetPart2Content(worksheetPart2);

            // Create Sheet1
            WorksheetPart worksheetPart3 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPart3Content(worksheetPart3);

            // Add PivotTablePart to Sheet1
            PivotTablePart pivotTablePart1 = worksheetPart3.AddNewPart<PivotTablePart>("rId1");
            GeneratePivotTablePart1Content(pivotTablePart1);

            // Add PivotTableCacheDefinitionPart to PivotTablePart
            PivotTableCacheDefinitionPart pivotTableCacheDefinitionPart1 = pivotTablePart1.AddNewPart<PivotTableCacheDefinitionPart>("rId1");
            GeneratePivotTableCacheDefinitionPart1Content(pivotTableCacheDefinitionPart1);

            // Add PivotTableCacheDefinitionPart to PivotTableCacheDefinitionPart
            PivotTableCacheRecordsPart pivotTableCacheRecordsPart1 = pivotTableCacheDefinitionPart1.AddNewPart<PivotTableCacheRecordsPart>("rId1");
            GeneratePivotTableCacheRecordsPart1Content(pivotTableCacheRecordsPart1);

            WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId6");
            GenerateWorkbookStylesPart1Content(workbookStylesPart1);


            workbookPart1.AddPart(pivotTableCacheDefinitionPart1, "rId4");
        }

        // Generates content of workbookPart1.
        private void GenerateWorkbookPart1Content(WorkbookPart workbookPart1)
        {
            Workbook workbook1 = new Workbook();

            Sheets sheets1 = new Sheets();
            Sheet sheet1 = new Sheet() { Name = "Sheet1", SheetId = (UInt32Value)1U, Id = "rId1" };
            Sheet sheet2 = new Sheet() { Name = "Sheet2", SheetId = (UInt32Value)2U, Id = "rId2" };

            sheets1.Append(sheet1);
            sheets1.Append(sheet2);

            PivotCaches pivotCaches1 = new PivotCaches();
            PivotCache pivotCache1 = new PivotCache() { CacheId = (UInt32Value)2U, Id = "rId4" };

            pivotCaches1.Append(pivotCache1);

            workbook1.Append(sheets1);
            workbook1.Append(pivotCaches1);

            workbookPart1.Workbook = workbook1;
        }

        // Generates content of sharedStringTablePart1.
        private void GenerateSharedStringTablePart1Content(SharedStringTablePart sharedStringTablePart1)
        {
            SharedStringTable sharedStringTable1 = new SharedStringTable() { Count = (UInt32Value)5U, UniqueCount = (UInt32Value)5U };

            SharedStringItem sharedStringItem1 = new SharedStringItem();
            Text text1 = new Text();
            text1.Text = "id";

            SharedStringItem sharedStringItem2 = new SharedStringItem();
            Text text2 = new Text();
            text2.Text = "score";

            SharedStringItem sharedStringItem3 = new SharedStringItem();
            Text text3 = new Text();
            text3.Text = "Sum of score";

            SharedStringItem sharedStringItem4 = new SharedStringItem();
            Text text4 = new Text();
            text4.Text = "Row Labels";

            SharedStringItem sharedStringItem5 = new SharedStringItem();
            Text text5 = new Text();
            text5.Text = "Grand Total";

            sharedStringItem1.Append(text1);
            sharedStringItem2.Append(text2);
            sharedStringItem3.Append(text3);
            sharedStringItem4.Append(text4);
            sharedStringItem5.Append(text5);

            sharedStringTable1.Append(sharedStringItem1);
            sharedStringTable1.Append(sharedStringItem2);
            sharedStringTable1.Append(sharedStringItem3);
            sharedStringTable1.Append(sharedStringItem4);
            sharedStringTable1.Append(sharedStringItem5);

            sharedStringTablePart1.SharedStringTable = sharedStringTable1;
        }

        // Generates content of worksheetPart2(create test value in Sheet2)
        private void GenerateWorksheetPart2Content(WorksheetPart worksheetPart2)
        {
            Worksheet worksheet2 = new Worksheet();
            SheetDimension sheetDimension2 = new SheetDimension() { Reference = "A1:B4" };

            SheetViews sheetViews2 = new SheetViews();

            SheetView sheetView2 = new SheetView() { WorkbookViewId = (UInt32Value)0U };
            Selection selection1 = new Selection() { ActiveCell = "B4", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "B4" } };

            sheetView2.Append(selection1);

            sheetViews2.Append(sheetView2);
            SheetFormatProperties sheetFormatProperties2 = new SheetFormatProperties() { DefaultRowHeight = 15D, DyDescent = 0.25D };

            SheetData sheetData2 = new SheetData();

            Row row1 = new Row() { RowIndex = (UInt32Value)1U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell1 = new Cell() { CellReference = "A1", DataType = CellValues.SharedString };
            CellValue cellValue1 = new CellValue();
            cellValue1.Text = "0";

            cell1.Append(cellValue1);

            Cell cell2 = new Cell() { CellReference = "B1", DataType = CellValues.SharedString };
            CellValue cellValue2 = new CellValue();
            cellValue2.Text = "1";

            cell2.Append(cellValue2);

            row1.Append(cell1);
            row1.Append(cell2);

            Row row2 = new Row() { RowIndex = (UInt32Value)2U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell3 = new Cell() { CellReference = "A2" };
            CellValue cellValue3 = new CellValue();
            cellValue3.Text = "1";

            cell3.Append(cellValue3);

            Cell cell4 = new Cell() { CellReference = "B2" };
            CellValue cellValue4 = new CellValue();
            cellValue4.Text = "100";

            cell4.Append(cellValue4);

            row2.Append(cell3);
            row2.Append(cell4);

            Row row3 = new Row() { RowIndex = (UInt32Value)3U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell5 = new Cell() { CellReference = "A3" };
            CellValue cellValue5 = new CellValue();
            cellValue5.Text = "2";

            cell5.Append(cellValue5);

            Cell cell6 = new Cell() { CellReference = "B3" };
            CellValue cellValue6 = new CellValue();
            cellValue6.Text = "120";

            cell6.Append(cellValue6);

            row3.Append(cell5);
            row3.Append(cell6);

            Row row4 = new Row() { RowIndex = (UInt32Value)4U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell7 = new Cell() { CellReference = "A4" };
            CellValue cellValue7 = new CellValue();
            cellValue7.Text = "3";

            cell7.Append(cellValue7);

            Cell cell8 = new Cell() { CellReference = "B4" };
            CellValue cellValue8 = new CellValue();
            cellValue8.Text = "132";

            cell8.Append(cellValue8);

            row4.Append(cell7);
            row4.Append(cell8);

            sheetData2.Append(row1);
            sheetData2.Append(row2);
            sheetData2.Append(row3);
            sheetData2.Append(row4);

            worksheet2.Append(sheetDimension2);
            worksheet2.Append(sheetViews2);
            worksheet2.Append(sheetFormatProperties2);
            worksheet2.Append(sheetData2);

            worksheetPart2.Worksheet = worksheet2;
        }

        // Generates content of worksheetPart3(create Sheet1)
        private void GenerateWorksheetPart3Content(WorksheetPart worksheetPart3)
        {
            Worksheet worksheet3 = new Worksheet();
            SheetDimension sheetDimension3 = new SheetDimension() { Reference = "A1:B5" };

            SheetViews sheetViews3 = new SheetViews();
            SheetView sheetView3 = new SheetView() { TabSelected = true, WorkbookViewId = (UInt32Value)0U };

            sheetViews3.Append(sheetView3);
            SheetFormatProperties sheetFormatProperties3 = new SheetFormatProperties() { DefaultRowHeight = 15D, DyDescent = 0.25D };

            Columns columns1 = new Columns();
            Column column1 = new Column() { Min = (UInt32Value)1U, Max = (UInt32Value)1U, Width = 13D, BestFit = true, CustomWidth = true };
            Column column2 = new Column() { Min = (UInt32Value)2U, Max = (UInt32Value)2U, Width = 12.28515625D, BestFit = true, CustomWidth = true };

            columns1.Append(column1);
            columns1.Append(column2);

            SheetData sheetData3 = new SheetData();

            Row row5 = new Row() { RowIndex = (UInt32Value)1U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell9 = new Cell() { CellReference = "A1", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
            CellValue cellValue9 = new CellValue();
            cellValue9.Text = "3";

            cell9.Append(cellValue9);

            Cell cell10 = new Cell() { CellReference = "B1", DataType = CellValues.SharedString };
            CellValue cellValue10 = new CellValue();
            cellValue10.Text = "2";

            cell10.Append(cellValue10);

            row5.Append(cell9);
            row5.Append(cell10);

            Row row6 = new Row() { RowIndex = (UInt32Value)2U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell11 = new Cell() { CellReference = "A2", StyleIndex = (UInt32Value)3U };
            CellValue cellValue11 = new CellValue();
            cellValue11.Text = "1";

            cell11.Append(cellValue11);

            Cell cell12 = new Cell() { CellReference = "B2", StyleIndex = (UInt32Value)1U };
            CellValue cellValue12 = new CellValue();
            cellValue12.Text = "100";

            cell12.Append(cellValue12);

            row6.Append(cell11);
            row6.Append(cell12);

            Row row7 = new Row() { RowIndex = (UInt32Value)3U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell13 = new Cell() { CellReference = "A3", StyleIndex = (UInt32Value)3U };
            CellValue cellValue13 = new CellValue();
            cellValue13.Text = "2";

            cell13.Append(cellValue13);

            Cell cell14 = new Cell() { CellReference = "B3", StyleIndex = (UInt32Value)1U };
            CellValue cellValue14 = new CellValue();
            cellValue14.Text = "120";

            cell14.Append(cellValue14);

            row7.Append(cell13);
            row7.Append(cell14);

            Row row8 = new Row() { RowIndex = (UInt32Value)4U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell15 = new Cell() { CellReference = "A4", StyleIndex = (UInt32Value)3U };
            CellValue cellValue15 = new CellValue();
            cellValue15.Text = "3";

            cell15.Append(cellValue15);

            Cell cell16 = new Cell() { CellReference = "B4", StyleIndex = (UInt32Value)1U };
            CellValue cellValue16 = new CellValue();
            cellValue16.Text = "132";

            cell16.Append(cellValue16);

            row8.Append(cell15);
            row8.Append(cell16);

            Row row9 = new Row() { RowIndex = (UInt32Value)5U, Spans = new ListValue<StringValue>() { InnerText = "1:2" }, DyDescent = 0.25D };

            Cell cell17 = new Cell() { CellReference = "A5", StyleIndex = (UInt32Value)3U, DataType = CellValues.SharedString };
            CellValue cellValue17 = new CellValue();
            cellValue17.Text = "4";

            cell17.Append(cellValue17);

            Cell cell18 = new Cell() { CellReference = "B5", StyleIndex = (UInt32Value)1U };
            CellValue cellValue18 = new CellValue();
            cellValue18.Text = "352";

            cell18.Append(cellValue18);

            row9.Append(cell17);
            row9.Append(cell18);

            sheetData3.Append(row5);
            sheetData3.Append(row6);
            sheetData3.Append(row7);
            sheetData3.Append(row8);
            sheetData3.Append(row9);
            PageMargins pageMargins3 = new PageMargins() { Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };

            worksheet3.Append(sheetDimension3);
            worksheet3.Append(sheetViews3);
            worksheet3.Append(sheetFormatProperties3);
            worksheet3.Append(columns1);
            worksheet3.Append(sheetData3);
            worksheet3.Append(pageMargins3);

            worksheetPart3.Worksheet = worksheet3;
        }

        // Generates content of pivotTablePart1.
        private void GeneratePivotTablePart1Content(PivotTablePart pivotTablePart1)
        {
            PivotTableDefinition pivotTableDefinition1 = new PivotTableDefinition() { Name = "PivotTable1", CacheId = (UInt32Value)2U, ApplyNumberFormats = false, ApplyBorderFormats = false, ApplyFontFormats = false, ApplyPatternFormats = false, ApplyAlignmentFormats = false, ApplyWidthHeightFormats = true, DataCaption = "Values", UpdatedVersion = 4, MinRefreshableVersion = 3, UseAutoFormatting = true, ItemPrintTitles = true, CreatedVersion = 4, Indent = (UInt32Value)0U, Outline = true, OutlineData = true, MultipleFieldFilters = false };
            Location location1 = new Location() { Reference = "A1:B5", FirstHeaderRow = (UInt32Value)1U, FirstDataRow = (UInt32Value)1U, FirstDataColumn = (UInt32Value)1U };

            PivotFields pivotFields1 = new PivotFields() { Count = (UInt32Value)2U };

            PivotField pivotField1 = new PivotField() { Axis = PivotTableAxisValues.AxisRow, ShowAll = false };

            Items items1 = new Items() { Count = (UInt32Value)4U };
            Item item1 = new Item() { Index = (UInt32Value)0U };
            Item item2 = new Item() { Index = (UInt32Value)1U };
            Item item3 = new Item() { Index = (UInt32Value)2U };
            Item item4 = new Item() { ItemType = ItemValues.Default };

            items1.Append(item1);
            items1.Append(item2);
            items1.Append(item3);
            items1.Append(item4);

            pivotField1.Append(items1);
            PivotField pivotField2 = new PivotField() { DataField = true, ShowAll = false };

            pivotFields1.Append(pivotField1);
            pivotFields1.Append(pivotField2);

            RowFields rowFields1 = new RowFields() { Count = (UInt32Value)1U };
            Field field1 = new Field() { Index = 0 };

            rowFields1.Append(field1);

            RowItems rowItems1 = new RowItems() { Count = (UInt32Value)4U };

            RowItem rowItem1 = new RowItem();
            MemberPropertyIndex memberPropertyIndex1 = new MemberPropertyIndex();

            rowItem1.Append(memberPropertyIndex1);

            RowItem rowItem2 = new RowItem();
            MemberPropertyIndex memberPropertyIndex2 = new MemberPropertyIndex() { Val = 1 };

            rowItem2.Append(memberPropertyIndex2);

            RowItem rowItem3 = new RowItem();
            MemberPropertyIndex memberPropertyIndex3 = new MemberPropertyIndex() { Val = 2 };

            rowItem3.Append(memberPropertyIndex3);

            RowItem rowItem4 = new RowItem() { ItemType = ItemValues.Grand };
            MemberPropertyIndex memberPropertyIndex4 = new MemberPropertyIndex();

            rowItem4.Append(memberPropertyIndex4);

            rowItems1.Append(rowItem1);
            rowItems1.Append(rowItem2);
            rowItems1.Append(rowItem3);
            rowItems1.Append(rowItem4);

            ColumnItems columnItems1 = new ColumnItems() { Count = (UInt32Value)1U };
            RowItem rowItem5 = new RowItem();

            columnItems1.Append(rowItem5);

            DataFields dataFields1 = new DataFields() { Count = (UInt32Value)1U };
            DataField dataField1 = new DataField() { Name = "Sum of score", Field = (UInt32Value)1U, BaseField = 0, BaseItem = (UInt32Value)0U };

            dataFields1.Append(dataField1);
            PivotTableStyle pivotTableStyle1 = new PivotTableStyle() { Name = "PivotStyleMedium9", ShowRowHeaders = true, ShowColumnHeaders = true, ShowRowStripes = false, ShowColumnStripes = false, ShowLastColumn = true };

            PivotTableDefinitionExtensionList pivotTableDefinitionExtensionList1 = new PivotTableDefinitionExtensionList();

            pivotTableDefinition1.Append(location1);
            pivotTableDefinition1.Append(pivotFields1);
            pivotTableDefinition1.Append(rowFields1);
            pivotTableDefinition1.Append(rowItems1);
            pivotTableDefinition1.Append(columnItems1);
            pivotTableDefinition1.Append(dataFields1);
            pivotTableDefinition1.Append(pivotTableStyle1);
            pivotTableDefinition1.Append(pivotTableDefinitionExtensionList1);

            pivotTablePart1.PivotTableDefinition = pivotTableDefinition1;
        }

        // Generates content of pivotTableCacheDefinitionPart1.
        private void GeneratePivotTableCacheDefinitionPart1Content(PivotTableCacheDefinitionPart pivotTableCacheDefinitionPart1)
        {
            PivotCacheDefinition pivotCacheDefinition1 = new PivotCacheDefinition() { Id = "rId1", RefreshedBy = "Author", RefreshedDate = 40905.65532824074D, CreatedVersion = 4, RefreshedVersion = 4, MinRefreshableVersion = 3, RecordCount = (UInt32Value)3U };

            CacheSource cacheSource1 = new CacheSource() { Type = SourceValues.Worksheet };
            WorksheetSource worksheetSource1 = new WorksheetSource() { Reference = "A1:B4", Sheet = "Sheet2" };

            cacheSource1.Append(worksheetSource1);

            CacheFields cacheFields1 = new CacheFields() { Count = (UInt32Value)2U };

            CacheField cacheField1 = new CacheField() { Name = "id", NumberFormatId = (UInt32Value)0U };

            SharedItems sharedItems1 = new SharedItems() { ContainsSemiMixedTypes = false, ContainsString = false, ContainsNumber = true, ContainsInteger = true, MinValue = 1D, MaxValue = 3D, Count = (UInt32Value)3U };
            NumberItem numberItem1 = new NumberItem() { Val = 1D };
            NumberItem numberItem2 = new NumberItem() { Val = 2D };
            NumberItem numberItem3 = new NumberItem() { Val = 3D };

            sharedItems1.Append(numberItem1);
            sharedItems1.Append(numberItem2);
            sharedItems1.Append(numberItem3);

            cacheField1.Append(sharedItems1);

            CacheField cacheField2 = new CacheField() { Name = "score", NumberFormatId = (UInt32Value)0U };
            SharedItems sharedItems2 = new SharedItems() { ContainsSemiMixedTypes = false, ContainsString = false, ContainsNumber = true, ContainsInteger = true, MinValue = 100D, MaxValue = 132D };

            cacheField2.Append(sharedItems2);

            cacheFields1.Append(cacheField1);
            cacheFields1.Append(cacheField2);

            PivotCacheDefinitionExtensionList pivotCacheDefinitionExtensionList1 = new PivotCacheDefinitionExtensionList();

            pivotCacheDefinition1.Append(cacheSource1);
            pivotCacheDefinition1.Append(cacheFields1);
            pivotCacheDefinition1.Append(pivotCacheDefinitionExtensionList1);

            pivotTableCacheDefinitionPart1.PivotCacheDefinition = pivotCacheDefinition1;
        }

        // Generates content of pivotTableCacheRecordsPart1.
        private void GeneratePivotTableCacheRecordsPart1Content(PivotTableCacheRecordsPart pivotTableCacheRecordsPart1)
        {
            PivotCacheRecords pivotCacheRecords1 = new PivotCacheRecords() { Count = (UInt32Value)3U };

            PivotCacheRecord pivotCacheRecord1 = new PivotCacheRecord();
            FieldItem fieldItem1 = new FieldItem() { Val = (UInt32Value)0U };
            NumberItem numberItem4 = new NumberItem() { Val = 100D };

            pivotCacheRecord1.Append(fieldItem1);
            pivotCacheRecord1.Append(numberItem4);

            PivotCacheRecord pivotCacheRecord2 = new PivotCacheRecord();
            FieldItem fieldItem2 = new FieldItem() { Val = (UInt32Value)1U };
            NumberItem numberItem5 = new NumberItem() { Val = 120D };

            pivotCacheRecord2.Append(fieldItem2);
            pivotCacheRecord2.Append(numberItem5);

            PivotCacheRecord pivotCacheRecord3 = new PivotCacheRecord();
            FieldItem fieldItem3 = new FieldItem() { Val = (UInt32Value)2U };
            NumberItem numberItem6 = new NumberItem() { Val = 132D };

            pivotCacheRecord3.Append(fieldItem3);
            pivotCacheRecord3.Append(numberItem6);

            pivotCacheRecords1.Append(pivotCacheRecord1);
            pivotCacheRecords1.Append(pivotCacheRecord2);
            pivotCacheRecords1.Append(pivotCacheRecord3);

            pivotTableCacheRecordsPart1.PivotCacheRecords = pivotCacheRecords1;
        }

        // Generates content of workbookStylesPart1.
        private void GenerateWorkbookStylesPart1Content(WorkbookStylesPart workbookStylesPart1)
        {
            Stylesheet stylesheet1 = new Stylesheet();
            Fonts fonts1 = new Fonts() { Count = (UInt32Value)1U, KnownFonts = true };
            Font font1 = new Font();
            FontSize fontSize1 = new FontSize() { Val = 11D };
            Color color1 = new Color() { Theme = (UInt32Value)1U };
            FontName fontName1 = new FontName() { Val = "Calibri" };
            FontFamilyNumbering fontFamilyNumbering1 = new FontFamilyNumbering() { Val = 2 };
            FontScheme fontScheme1 = new FontScheme() { Val = FontSchemeValues.Minor };

            font1.Append(fontSize1);
            font1.Append(color1);
            font1.Append(fontName1);
            font1.Append(fontFamilyNumbering1);
            font1.Append(fontScheme1);

            fonts1.Append(font1);

            Fills fills1 = new Fills() { Count = (UInt32Value)2U };
            Fill fill1 = new Fill();
            PatternFill patternFill1 = new PatternFill() { PatternType = PatternValues.None };
            fill1.Append(patternFill1);

            Fill fill2 = new Fill();
            PatternFill patternFill2 = new PatternFill() { PatternType = PatternValues.Gray125 };
            fill2.Append(patternFill2);

            fills1.Append(fill1);
            fills1.Append(fill2);

            Borders borders1 = new Borders() { Count = (UInt32Value)1U };

            Border border1 = new Border();
            LeftBorder leftBorder1 = new LeftBorder();
            RightBorder rightBorder1 = new RightBorder();
            TopBorder topBorder1 = new TopBorder();
            BottomBorder bottomBorder1 = new BottomBorder();
            DiagonalBorder diagonalBorder1 = new DiagonalBorder();

            border1.Append(leftBorder1);
            border1.Append(rightBorder1);
            border1.Append(topBorder1);
            border1.Append(bottomBorder1);
            border1.Append(diagonalBorder1);

            borders1.Append(border1);

            CellStyleFormats cellStyleFormats1 = new CellStyleFormats() { Count = (UInt32Value)1U };
            CellFormat cellFormat1 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };

            cellStyleFormats1.Append(cellFormat1);

            CellFormats cellFormats1 = new CellFormats() { Count = (UInt32Value)4U };
            CellFormat cellFormat2 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };
            CellFormat cellFormat3 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true };
            CellFormat cellFormat4 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, PivotButton = true };
            CellFormat cellFormat5 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyAlignment = true };

            cellFormats1.Append(cellFormat2);
            cellFormats1.Append(cellFormat3);
            cellFormats1.Append(cellFormat4);
            cellFormats1.Append(cellFormat5);

            CellStyles cellStyles1 = new CellStyles() { Count = (UInt32Value)1U };
            CellStyle cellStyle1 = new CellStyle() { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

            cellStyles1.Append(cellStyle1);
            DifferentialFormats differentialFormats1 = new DifferentialFormats() { Count = (UInt32Value)0U };

            stylesheet1.Append(fonts1);
            stylesheet1.Append(fills1);
            stylesheet1.Append(borders1);
            stylesheet1.Append(cellStyleFormats1);
            stylesheet1.Append(cellFormats1);
            stylesheet1.Append(cellStyles1);
            stylesheet1.Append(differentialFormats1);

            workbookStylesPart1.Stylesheet = stylesheet1;
        }
    }
}
