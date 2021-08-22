import bright.serialization.ByteBuf;

import java.io.IOException;
import java.nio.file.Paths;

public class Main {

    public static void main(String[] args) throws IOException {
        var tables = new cfg.Tables(Main::createByteBufFromFile);
        System.out.println("== load succ ==");
    }

    private static ByteBuf createByteBufFromFile(String file) throws java.io.IOException    {
        return new ByteBuf(java.nio.file.Files.readAllBytes(Paths.get("../GenerateDatas/bin", file + ".bin")));
    }
}
